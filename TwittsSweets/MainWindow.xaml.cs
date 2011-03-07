using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Twitterizer;

namespace TwittsSweets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SendRequest();
        }

        public void SendRequest()
        {
            try
            {
                OAuthTokens tokens = new OAuthTokens();
                //tokens.AccessToken = "XXX";
                //tokens.AccessTokenSecret = "XXX";
                tokens.ConsumerKey = "ZdOK5fvFEZWrjhRVqINIw";
                tokens.ConsumerSecret = "sj6fDLm9MJN82uNtGLivM0oPV1W0pfHygrTtPI46c";

                TwitterResponse<TwitterUser> showUserResponse = TwitterUser.Show(tokens, "olgert");
                if (showUserResponse.Result == RequestResult.Success)
                {
                    //DisplayUserDetails(showUserResponse.ResponseObject);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
