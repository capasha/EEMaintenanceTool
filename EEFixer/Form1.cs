using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using PlayerIOClient;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace EEFixer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Connection con_;
        private Client client_;
        private bool signedUniverse = false;
        private Semaphore s1 = new Semaphore(0, 1);
        private int startX = 0;
        private int startY = 0;

        List<string> currentFile = new List<string>();
        private Dictionary<string, FavDB> favdata = new Dictionary<string, FavDB>();
        Dictionary<string, string> data = new Dictionary<string, string>();
        private string nick = null;
        private int morethanxFavs = 85;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"Everybody Edits - Maintenance Tool v{this.ProductVersion}";
            ToolTip tp = new ToolTip();
            tp.SetToolTip(EEUInfoPictureBox, "Click on the button to join\nEverybody Edits Universe");
            tp.SetToolTip(LSOInfoPictureBox, "Only delete cookies when needed\nIf you want to remove them You're login\n and history will be deleted.");
            tp.SetToolTip(EEUInfosPictureBox, "This will lookup if you have joined\nEverybody Edits Universe or not");
            tp.SetToolTip(BetaInfoPictureBox, "This will lookup if you are a beta user or not");
            tp.SetToolTip(LSOInfosPictureBox, "Looking up if you have flash cookies (LSO) for EE.");
            tp.SetToolTip(GEInfoPictureBox, "Looking up if Everybody Edits exist on PlayerIO.");
            tp.SetToolTip(GOInfoPictureBox, "Looking up if Everybody Edits website is up and running");
            //DownOrNot();
            GameExist();
            DownOrNot();
            DetectLSO();

        }


        #region connections


        //Connect to lobby
        private void TryLobbyConnect(string id, Client client)
        {
            client_ = client;
            client.Multiplayer.CreateJoinRoom(id, $"Lobby{client.BigDB.Load("config", "config")["version"]}", true, null, null,
            (Connection con) =>
            {
                lobbyConnected(con, client);
            },
            (PlayerIOError error) =>
            {
                TryLobbyConnect(id, client);
            });
        }

        //Read data from lobby connection.
        private void lobbyConnected(Connection con, Client client)
        {
            con_ = con;
            con.OnMessage += (s, m) =>
            {
                switch (m.Type)
                {
                    case "universeOptIn":
                        if (m.GetBoolean(0))
                        {

                            RT.AppendText(LogRichTextBox, $"Info: EEU: You just signed up for closed Beta.\n", Color.DarkBlue);
                        }
                        else
                        {

                            RT.AppendText(LogRichTextBox, $"Error: EEU: You are already signed up to closed beta.\n", Color.DarkRed);
                        }
                        break;
                    case "LobbyTo":
                        TryLobbyConnect(m.GetString(0), client);
                        break;
                    case "connectioncomplete":

                        RT.AppendText(LogRichTextBox, $"Info: Successfully connected to lobby.\n", Color.DarkBlue);

                        con.Send("getMySimplePlayerObject");
                        break;
                    case "getMySimplePlayerObject":

                        RT.AppendText(LogRichTextBox, $"Info: Reading your database data.\n", Color.DarkBlue);
                        int total = ExtractPlayerObjectsMessage(m) + 1;
                        string nickname = m[(uint)total].ToString();
                        signedUniverse = Convert.ToBoolean(m[(uint)total + 30]);
                        nick = nickname;
                        RT.AppendText(LogRichTextBox, $"Info: Connected as: {nickname}.\n", Color.DarkBlue);
                        bool havebeta = false;
                        client.PayVault.Refresh(() =>
                        {
                            //if (client.PayVault.Has("pro")) //Beta;
                            if (client.PayVault.Has("pro")) havebeta = true;
                            s1.Release();
                        });

                        s1.WaitOne();
                        if (havebeta)
                        {
                            if (BetaPictureBox.InvokeRequired)
                            {
                                BetaPictureBox.Invoke((MethodInvoker)delegate
                                {

                                    BetaPictureBox.Image = Properties.Resources.tick;

                                });
                            }
                        }
                        if (signedUniverse)
                        {
                            if (UniversePictureBox.InvokeRequired)
                            {
                                UniversePictureBox.Invoke((MethodInvoker)delegate
                                {

                                    UniversePictureBox.Image = Properties.Resources.tick;

                                });
                            }
                        }
                        if (!signedUniverse && havebeta)
                        {
                            if (EEUJoinButton.InvokeRequired)
                            {
                                EEUJoinButton.Invoke((MethodInvoker)delegate
                                {
                                    EEUJoinButton.Enabled = true;
                                });
                            }
                        }


                        string[] favsid = m[(uint)total + 27].ToString().Split((char)0x1399);
                        string[] favsname = m[(uint)total + 28].ToString().Split((char)0x1399);

                        int totals = favsid.Count();
                        if (FavoritesCountLabel.InvokeRequired)
                        {
                            FavoritesCountLabel.Invoke((MethodInvoker)delegate
                            {
                                FavoritesCountLabel.Text = totals.ToString();
                                if (totals <= morethanxFavs)
                                {
                                    FavoritesCountLabel.ForeColor = Color.DarkGreen;
                                }
                                else
                                {
                                    FavoritesCountLabel.ForeColor = Color.DarkRed;
                                }
                            });
                        }
                        for (int i = 0; i < favsid.Count(); i++)
                        {
                            if (FavoritesListView.InvokeRequired)
                            {
                                FavoritesListView.Invoke((MethodInvoker)delegate
                                {
                                    ListViewItem lvi = new ListViewItem();
                                    lvi.Text = favsname[i];
                                    lvi.SubItems.Add(favsid[i]);
                                    FavoritesListView.Items.Add(lvi);
                                });

                            }
                        }
                        if (File.Exists($"{Directory.GetCurrentDirectory()}\\favs.json"))
                        {
                            var output = JObject.Parse(File.ReadAllText($"{Directory.GetCurrentDirectory()}\\favs.json"));
                            foreach (var property in output)
                            {
                                if (property.Key == nick)
                                {
                                    if (property.Value != null)
                                    {
                                        data = JsonConvert.DeserializeObject<Dictionary<string, string>>(property.Value["worlds"].ToString());
                                        foreach (KeyValuePair<string, string> kvp in data)
                                        {
                                            if (FavBackupListView.InvokeRequired)
                                            {
                                                FavBackupListView.Invoke((MethodInvoker)delegate
                                                {
                                                    ListViewItem lvi1 = new ListViewItem();
                                                    lvi1.Text = kvp.Value;
                                                    lvi1.SubItems.Add(kvp.Key);
                                                    FavBackupListView.Items.Add(lvi1);
                                                });
                                            }
                                        }
                                    }
                                }
                            }


                        }


                        break;
                    case "linked":
                        client.Multiplayer.CreateJoinRoom("$service-room", "AuthRoom", true, null, new Dictionary<string, string>() { { "type", "Link" } }, (Connection conn) =>
                        {
                            conn.OnMessage += (object sender1, PlayerIOClient.Message mm) =>
                            {
                                if (mm.Type == "auth")
                                {
                                    PlayerIO.Authenticate("everybody-edits-su9rn58o40itdbnw69plyw", "connected", new Dictionary<string, string>() { { "userId", mm.GetString(0) }, { "auth", mm.GetString(1) } }, null, (Client client1) =>
                                    {
                                        con.Disconnect();
                                        TryLobbyConnect(string.Format("{0}_{1}", client1.ConnectUserId, RandomString(5)), client1);
                                    }, (PlayerIOError error) =>
                                    {
                                        RT.AppendText(LogRichTextBox, $"Error: Linked Login: {error.Message}\n", Color.DarkRed);
                                    });
                                }
                            };
                        },
                        (PlayerIOError error) =>
                        {
                            RT.AppendText(LogRichTextBox, $"Error: Linked Create Room: {error.Message}\n", Color.DarkRed);
                        });
                        break;
                }
            };
        }
        #endregion

        #region Buttons and misc

        //Delete flash cookies (LSO)
        private void DelFButton_Click(object sender, EventArgs e)
        {
            if (currentFile.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you want to delete the Flash Cookies?\nEE's Flash Cookies store history and login information.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    foreach (var file in currentFile)
                    {
                        File.Delete(file);
                    }
                }
            }
            currentFile.Clear();
            DetectLSO();
        }


        //Open up About Window.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
        //Open up Delete popup when selecting a favorited world.
        private void FavoritesListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && FavoritesListView.SelectedIndices.Count == 1)

            {
                ContextMenuStrip FavoriteMenuStrip1 = new ContextMenuStrip();
                FavoriteMenuStrip1.Items.Add("Delete");
                FavoriteMenuStrip1.Items[0].Image = Properties.Resources.delete;
                FavoriteMenuStrip1.Show(FavoritesListView, new Point(e.X, e.Y));
                FavoriteMenuStrip1.MouseClick += FavoriteMenuStrip1_MouseClick;
            }
        }

        //Delete favorited world
        private void FavoriteMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FavoritesListView.SelectedIndices.Count == 1)
            {
                var id = FavoritesListView.SelectedItems[0].SubItems[1].Text;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = FavoritesListView.SelectedItems[0].SubItems[0].Text;
                lvi.SubItems.Add(FavoritesListView.SelectedItems[0].SubItems[1].Text);
                FavBackupListView.Items.Add(lvi);

                if (!data.ContainsKey(id))
                {
                    data.Add(id, FavoritesListView.SelectedItems[0].SubItems[0].Text);
                }

                client_.Multiplayer.CreateJoinRoom(id, id.Substring(0, 2) == "BW" ? $"Beta{client_.BigDB.Load("config", "config")["version"]}" : $"Everybodyedits{client_.BigDB.Load("config", "config")["version"]}", true, null, new Dictionary<string, string>() { { "QuickAction", "unfavorite" } }, (Connection con) =>
                {
                    con.OnMessage += (s, m) =>
                    {
                        switch (m.Type)
                        {
                            case "unfavorited":
                                if (FavoritesCountLabel.InvokeRequired)
                                {
                                    FavoritesCountLabel.Invoke((MethodInvoker)delegate
                                    {
                                        int tot = Convert.ToInt32(FavoritesCountLabel.Text);
                                        int calc = tot - 1;
                                        if (calc <= morethanxFavs)
                                        {
                                            FavoritesCountLabel.ForeColor = Color.DarkGreen;
                                        }
                                        else
                                        {
                                            FavoritesCountLabel.ForeColor = Color.DarkRed;
                                        }
                                        FavoritesCountLabel.Text = calc.ToString();
                                    });
                                }
                                con.Disconnect();
                                break;
                        }
                    };
                }, (PlayerIOError error) =>
                {

                });
                FavoritesListView.SelectedItems[0].Remove();
            }
        }


        //Connect to EE lobby
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailTextBox.Text))
            {
                if (!string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    PlayerIO.QuickConnect.SimpleConnect("everybody-edits-su9rn58o40itdbnw69plyw", EmailTextBox.Text, PasswordTextBox.Text, null, (Client client) =>
                    {
                        TryLobbyConnect($"{client.ConnectUserId}_{RandomString(5)}", client);

                        RT.AppendText(LogRichTextBox, $"Info: Login: Trying to login to EE\n", Color.DarkBlue);
                    }, (PlayerIOError error) =>
                    {

                        RT.AppendText(LogRichTextBox, $"Error: Login: {error.Message}\n", Color.DarkRed);
                    });
                }
            }
        }
        //Opt-in to EEU Closed Beta
        private void EEUJoinButton_Click(object sender, EventArgs e)
        {
            if (con_ != null) con_.Send("universeOptIn");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nick != null)
            {
                favdata.Add(nick, new FavDB() { worlds = data });
                File.WriteAllText($"{Directory.GetCurrentDirectory()}\\favs.json", JsonConvert.SerializeObject(favdata, Formatting.Indented));
            }
        }

        private void FavBackupListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FavBackupListView.SelectedIndices.Count == 1)
            {
                RoomIDTextBox.Text = FavBackupListView.SelectedItems[0].SubItems[1].Text;
            }
        }
        #endregion

        #region Tools


        //Return count for PlayerObjects
        private int ExtractPlayerObjectsMessage(PlayerIOClient.Message param)
        {
            int _loc2_ = -1;
            int _loc3_ = -1;
            int _loc4_ = 0;
            while (_loc4_ < param.Count)
            {

                if (param[(UInt32)_loc4_].GetType() == typeof(string) && param.GetString(Convert.ToUInt32(_loc4_)) == "ss")
                {
                    _loc2_ = _loc4_;
                }
                else if (param[(UInt32)_loc4_].GetType() == typeof(string) && param.GetString(Convert.ToUInt32(_loc4_)) == "se")
                {
                    _loc3_ = _loc4_;
                }
                _loc4_++;
            }
            if (_loc3_ == -1)
            {
                Console.WriteLine("Settings end is missing.");
            }
            if (_loc2_ == -1)
            {
                return _loc3_;
            }
            return _loc3_;
        }

        //Generate a random string
        private string RandomString(int length)
        {
            const string chars = "abcdefghijlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        private void DetectLSO()
        {

            string[] paths = new string[1];

            var path = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Macromedia\Flash Player\#SharedObjects\");
            var path2 = Path.GetFullPath($"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}{@"\Google\Chrome\User Data\Default\Pepper Data\Shockwave Flash\WritableRoot\#SharedObjects\"}");

            paths = new string[] { path, path2 };
            foreach (var value in paths)
            {
                foreach (string file in Directory.EnumerateFiles(value, "*.sol", SearchOption.AllDirectories))
                {

                    if (file.Contains(@"everybodyedits.com\ssx.sol"))
                    {
                        currentFile.Add(file);
                    }

                }
            }

            if (currentFile.Count >= 1)
            {
                RT.AppendText(LogRichTextBox, $"Info: Found {currentFile.Count} Flash Cookie(s) (LSO).\n", Color.DarkBlue);
                FlashCPictureBox.Image = Properties.Resources.btick;
                DelFButton.Enabled = true;
            }
            else
            {
                FlashCPictureBox.Image = Properties.Resources.tick;
                DelFButton.Enabled = false;
            }
        }
        //Is ee down for me or everyone else
        private void DownOrNot()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.downfor.cloud/httpcheck/everybodyedits.com");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:71.0) Gecko/20100101 Firefox/71.0";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            WebResponse response = request.GetResponse();
            string apiStatus = null;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                apiStatus = reader.ReadToEnd();
            }
            try
            {
                JObject ob = JObject.Parse(apiStatus);
                if (Convert.ToBoolean(ob["isDown"]))
                {
                    GameOnPictureBox.Image = Properties.Resources.cross;
                }
                else
                {
                    GameOnPictureBox.Image = Properties.Resources.tick;
                }
            }
            catch
            {
            }

        }

        //Does EE exist
        private void GameExist()
        {
            PlayerIO.QuickConnect.SimpleConnect("everybody-edits-su9rn58o40itdbnw69plyw", "guest", "guest", null, (Client client) =>
            {
                if (GameEPictureBox.InvokeRequired)
                {
                    GameEPictureBox.Invoke((MethodInvoker)delegate
                    {

                        GameEPictureBox.Image = Properties.Resources.tick;

                    });
                }
            }, (PlayerIOError error) =>
            {
                if (GameEPictureBox.InvokeRequired)
                {
                    GameEPictureBox.Invoke((MethodInvoker)delegate
                    {

                        GameEPictureBox.Image = Properties.Resources.cross;

                    });
                }
            });
        }



        #endregion

    }

    #region Classes
    public static class RT
    {
        //Set Color on the text in richtextbox
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            if (box.InvokeRequired)
            {
                box.Invoke((MethodInvoker)delegate
                {
                    box.SelectionStart = box.TextLength;
                    box.SelectionLength = 0;

                    box.SelectionColor = color;
                    box.AppendText(text);
                    box.SelectionColor = box.ForeColor;
                });
            }
            else
            {
                box.SelectionStart = box.TextLength;
                box.SelectionLength = 0;

                box.SelectionColor = color;
                box.AppendText(text);
                box.SelectionColor = box.ForeColor;
            }
        }
    }

    public class FavDB
    {
        public Dictionary<string, string> worlds { get; set; }
    }
    #endregion

}

