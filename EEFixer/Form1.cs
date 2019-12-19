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
namespace EEFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Connection con_;
        public static Client client_;
        public static bool signedUniverse = false;
        public static Semaphore s1 = new Semaphore(0, 1);
        public static int morethanxFavs = 85;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"Everybody Edits - Maintenance Tool v{this.ProductVersion}";
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

                            RT.AppendText(LogRichTextBox, $"Error: EEU: You are already signed up.\n", Color.DarkRed);
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
        }
    }
    #endregion

}

