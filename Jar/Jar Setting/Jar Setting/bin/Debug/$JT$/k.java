 

import java.io.PrintStream;
import javax.microedition.lcdui.*;

public final class k extends Canvas
{

    public k(Image image)
    {
        a = image;
        if(!isDoubleBuffered())
            try
            {
                b = Image.createImage(getWidth(), getHeight());
                c = b.getGraphics();
                return;
            }
            catch(Exception exception)
            {
                System.out.println(exception + "bufferCreate err");
            }
    }

    public final void paint(Graphics g)
    {
        if(isDoubleBuffered())
        {
            g.drawImage(a, getWidth() / 2, getHeight() / 2 - a.getHeight() / 2, 17);
            return;
        } else
        {
            c.setClip(0, 10, getWidth(), getHeight());
            c.drawImage(a, 0, 0, 17);
            g.drawImage(b, 0, 0, 17);
            return;
        }
    }

    public Image a;
    public Image b;
    public Graphics c;
}
