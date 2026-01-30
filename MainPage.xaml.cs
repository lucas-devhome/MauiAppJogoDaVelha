namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        Button[,] tabuleiro;
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();

            tabuleiro = new Button[3, 3]
            {
                { btn20, btn21, btn22 },
                { btn30, btn31, btn32 },
                { btn40, btn41, btn42 }
            };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.Text = vez;
            btn.IsEnabled = false;

            // Cor automática
            btn.TextColor = CorDoJogador(vez);

            if (VerificarVencedor(vez))
            {
                DisplayAlertAsync("Parabéns!", $"O jogador {vez} venceu!", "OK");
                Zerar();
                return;
            }

            if (VerificarEmpate())
            {
                DisplayAlertAsync("Deu velha!", "Ninguém venceu 😅", "OK");
                Zerar();
                return;
            }

            // Troca de jogador
            vez = vez == "X" ? "O" : "X";
            label_vez.Text = $"Vez do {vez} jogar";
        }

        bool VerificarVencedor(string jogador)
        {
            // Linhas
            for (int i = 0; i < 3; i++)
                if (tabuleiro[i, 0].Text == jogador &&
                    tabuleiro[i, 1].Text == jogador &&
                    tabuleiro[i, 2].Text == jogador)
                    return true;

            // Colunas
            for (int j = 0; j < 3; j++)
                if (tabuleiro[0, j].Text == jogador &&
                    tabuleiro[1, j].Text == jogador &&
                    tabuleiro[2, j].Text == jogador)
                    return true;

            // Diagonais
            if (tabuleiro[0, 0].Text == jogador &&
                tabuleiro[1, 1].Text == jogador &&
                tabuleiro[2, 2].Text == jogador)
                return true;

            if (tabuleiro[0, 2].Text == jogador &&
                tabuleiro[1, 1].Text == jogador &&
                tabuleiro[2, 0].Text == jogador)
                return true;

            return false;
        }

        bool VerificarEmpate()
        {
            return tabuleiro
                .Cast<Button>()
                .All(b => !string.IsNullOrEmpty(b.Text));
        }


        void Zerar()
        {
            foreach (var btn in tabuleiro)
            {
                btn.Text = "";
                btn.IsEnabled = true;
            }

            vez = "X";
            label_vez.Text = "Vez do X jogar";
        }

        Color CorDoJogador(string jogador)
            => jogador == "X" ? Colors.DodgerBlue : Colors.Orange;
    }
}
