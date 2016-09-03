 

import java.io.PrintStream;
import java.util.Vector;
import javax.microedition.lcdui.*;

public final class p
    implements CommandListener
{

    public p(String s, int l)
    {
        k = s;
        j = l;
        d();
    }

    public final int a()
    {
        return a.size();
    }

    public final n a(int l)
    {
        return (n)a.elementAt(l);
    }

    public final void a(n n1)
    {
        if(a.size() >= 10)
            a.removeElementAt(0);
        a.addElement(n1);
        c();
    }

    public final void a(Display display, Displayable displayable, Displayable displayable1, g g1)
    {
        h = display;
        if(displayable1 != null)
            i = displayable1;
        else
            i = h.getCurrent();
        System.out.println(i);
        g = g1;
        b = new List("书签列表:" + a.size(), 3);
        for(int l = 0; l < a.size(); l++)
        {
            n n1 = (n)a.elementAt(l);
            b.append("[" + n1.a(j) + "]" + n1.a, null);
        }

        f = new Command("转到该书签", 4, 1);
        d = new Command("删除该书签", 1, 2);
        e = new Command("删除全部书签", 1, 2);
        c = new Command("返回", 2, 2);
        if(a.size() > 0)
        {
            b.addCommand(f);
            b.addCommand(d);
            b.addCommand(e);
        }
        b.addCommand(c);
        b.setCommandListener(this);
        h.setCurrent(b);
    }

    public final void commandAction(Command command, Displayable displayable)
    {
        int l = b.getSelectedIndex();
        if(command == d)
        {
            if(l >= 0)
            {
                a.removeElementAt(l);
                b.delete(l);
                if(a.size() == 0)
                {
                    b.removeCommand(d);
                    b.removeCommand(e);
                    b.removeCommand(f);
                }
                c();
                return;
            }
        } else
        {
            if(command == e)
            {
                a.removeAllElements();
                for(; b.size() > 0; b.delete(0));
                b.removeCommand(d);
                b.removeCommand(e);
                b.removeCommand(f);
                c();
                return;
            }
            if(command == c)
                h.setCurrent(i);
            else
            if((command == f || command == List.SELECT_COMMAND) && l >= 0)
            {
                b.setTitle("请稍候...");
                n n1 = (n)a.elementAt(l);
                g.b(n1);
                h.setCurrent(i);
            }
            b();
        }
    }

    private void b()
    {
        b = null;
        c = null;
        d = null;
        f = null;
        e = null;
        g = null;
        h = null;
        i = null;
        System.gc();
    }

    private void c()
    {
        f f1;
        (f1 = new f()).a(a, k + "Bookmarks");
    }

    private void d()
    {
        f f1 = new f();
        a = f1.a(k + "Bookmarks");
    }

    private Vector a;
    private List b;
    private Command c;
    private Command d;
    private Command e;
    private Command f;
    private g g;
    private Display h;
    private Displayable i;
    private int j;
    private String k;
}
