namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            /* Verificar qual letra preencher no botão */
            if (vez == "X")
            {
                btn.Text = "X";
                label_vez.Text = "Vez do O jogar";
                vez = "O";
            } else
            {
                btn.Text = "O";
                label_vez.Text = "Vez do X jogar";
                vez = "X";
            }

            /* Verificar se o X ganhou nas linhas */
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na linha 1!", "ok");
                Zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na linha 2!", "ok");
                Zerar();
            }

            if (btn40.Text == "X" && btn41.Text == "X" && btn42.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na linha 3!", "ok");
                Zerar();
            }

            /* Verificar se o X ganhou nas colunas */
            if (btn20.Text == "X" && btn30.Text == "X" && btn40.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na coluna 1!", "ok");
                Zerar();
            }

            if (btn21.Text == "X" && btn31.Text == "X" && btn41.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na coluna 2!", "ok");
                Zerar();
            }

            if (btn22.Text == "X" && btn32.Text == "X" && btn42.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na coluna 3!", "ok");
                Zerar();
            }

            /* Verificar se o X ganhou nas diagonais */
            if (btn20.Text == "X" && btn31.Text == "X" && btn42.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na diagonal 1!", "ok");
                Zerar();
            }

            if (btn22.Text == "X" && btn31.Text == "X" && btn40.Text == "X")
            {
                DisplayAlertAsync("Parabéns!", "O jogador X ganhou na diagonal 2!", "ok");
                Zerar();
            }

            /* Verificar se o O ganhou nas linhas */
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na linha 1!", "ok");
                Zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na linha 2!", "ok");
                Zerar();
            }

            if (btn40.Text == "O" && btn41.Text == "O" && btn42.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na linha 3!", "ok");
                Zerar();
            }

            /* Verificar se o O ganhou nas colunas */
            if (btn20.Text == "O" && btn30.Text == "O" && btn40.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na coluna 1!", "ok");
                Zerar();
            }

            if (btn21.Text == "O" && btn31.Text == "O" && btn41.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na coluna 2!", "ok");
                Zerar();
            }

            if (btn22.Text == "O" && btn32.Text == "O" && btn42.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na coluna 3!", "ok");
                Zerar();
            }

            /* Verificar se o O ganhou nas diagonais */
            if (btn20.Text == "O" && btn31.Text == "O" && btn42.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na diagonal 1!", "ok");
                Zerar();
            }

            if (btn22.Text == "O" && btn31.Text == "O" && btn40.Text == "O")
            {
                DisplayAlertAsync("Parabéns!", "O jogador O ganhou na diagonal 2!", "ok");
                Zerar();
            }
        }

        void Zerar()
        {
            foreach (View i in ((Grid)this.Content).Children.Where(x => x.GetType() == typeof(Button)))
            {
                {
                    if (i.GetType() == typeof(Button))
                    {
                        Button btn = (Button)i;
                        btn.Text = "";
                        btn.IsEnabled = true;
                    }
                }
            }
        }
    }
}
