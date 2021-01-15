﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sotusei {
    /// <summary>
    /// AcPage.xaml の相互作用ロジック
    /// </summary>
    public partial class AcPage : Page {
        public AcPage() {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            

        }

        private void btapi_Click(object sender, RoutedEventArgs e) {
            var consumerkey = "84578F8035947FB06BFC5FB9E4902701";
            var userid = "76561199051966013";
            var api = new SteamApi(consumerkey, userid);

            var userInformation = api.GetUserInformation();
            tbname.Text = api.Json;

            var q = userInformation.Select(s => s.Name);

        }
    }
}
