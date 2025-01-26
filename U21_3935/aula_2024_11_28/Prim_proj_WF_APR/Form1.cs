namespace Prim_proj_WF_APR;

public partial class Form1 : Form
{
    public Form1(){
        InitializeComponent();
        Botao.Click += click_botao_nome;
        Next.Click += click_next;
    }

    private void click_botao_nome(object sender, EventArgs e){
        Msg.Text = "Bem vind@ " + Input_nome.Text;
        Input_nome.Text = "";
    }

    private void click_next(object sender, EventArgs e){
        Form2 form2 = new Form2();
        form2.ShowDialog();
    }
}
