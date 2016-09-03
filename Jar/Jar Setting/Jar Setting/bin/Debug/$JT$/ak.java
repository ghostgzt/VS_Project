 

import java.io.OutputStream;
import java.io.PrintStream;

public final class ak
{

    public ak(OutputStream outputstream, int i)
    {
        d = outputstream;
        a = 1024;
        b = new byte[1024];
        c = 0;
    }

    public final void a(int i)
    {
        if(i > 128)
            i -= 256;
        b[c++] = (byte)i;
        if(c == a)
        {
            try
            {
                d.write(b, 0, c);
            }
            // Misplaced declaration of an exception variable
            catch(int i)
            {
                System.out.println("Error: " + i);
            }
            c = 0;
        }
    }

    public final void a()
    {
        try
        {
            if(c > 0)
                d.write(b, 0, c);
            d.close();
            b = null;
            return;
        }
        // Misplaced declaration of an exception variable
        catch(ak this)
        {
            System.out.println("Error: " + this);
        }
    }

    private int a;
    private byte b[];
    private int c;
    private OutputStream d;
}
