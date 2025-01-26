using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    [DefaultValue(10)]
    public int BorderRadius { get; set; } = 5;

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Criar um GraphicsPath para os cantos arredondados
        GraphicsPath path = new GraphicsPath();
        Rectangle rect = ClientRectangle;
        int diameter = BorderRadius * 2;

        // Desenhar o botão com bordas arredondadas
        path.StartFigure();
        path.AddArc(new Rectangle(rect.X, rect.Y, diameter, diameter), 180, 90);
        path.AddArc(new Rectangle(rect.Right - diameter, rect.Y, diameter, diameter), 270, 90);
        path.AddArc(new Rectangle(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter), 0, 90);
        path.AddArc(new Rectangle(rect.X, rect.Bottom - diameter, diameter, diameter), 90, 90);
        path.CloseFigure();

        // Configurar clipping e desenho
        Region = new Region(path);

        // Desenhar fundo e borda
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Pintar o fundo do botão
        using (Brush brush = new SolidBrush(BackColor))
        {
            pevent.Graphics.FillPath(brush, path);
        }

        // Desenhar a borda do botão, se BorderColor estiver configurado
        if (FlatAppearance.BorderSize > 0)
        {
            using (Pen pen = new Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize))
            {
                pevent.Graphics.DrawPath(pen, path);
            }
        }

        // Desenhar o texto no centro do botão
        TextRenderer.DrawText(
            pevent.Graphics,
            Text,
            Font,
            rect,
            ForeColor
            // TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }
}
