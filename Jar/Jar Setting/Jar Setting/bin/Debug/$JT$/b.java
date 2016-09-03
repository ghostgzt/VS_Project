 

import java.util.Vector;

final class b
    implements Runnable
{

    b(z z1, String s)
    {
        b = z1;
        a = s;
    }

    public final void run()
    {
        Object obj = MemoDictMIDlet.g(z.a(b)) + MemoDictMIDlet.h(z.a(b)) + a;
        for(int i = 0; i < MemoDictMIDlet.cr().size(); i++)
        {
            ai ai1 = (ai)MemoDictMIDlet.cr().elementAt(i);
            if(((String) (obj)).compareTo(ai1.b) == 0)
            {
                MemoDictMIDlet.d("词典列表中已有该词典");
                return;
            }
        }

        int j = MemoDictMIDlet.aK().q();
        a a1;
        (a1 = new a(((String) (obj)))).a(false);
        String s = a1.j;
        a1.a();
        if(18 < a1.i)
        {
            MemoDictMIDlet.d("请升级软件后才能打开此词典");
            return;
        }
        if(a1.f != 68)
        {
            MemoDictMIDlet.d("词典格式不对");
            return;
        } else
        {
            obj = new ai(s, ((String) (obj)));
            MemoDictMIDlet.cr().insertElementAt(obj, j + 1);
            MemoDictMIDlet.i(j + 1);
            MemoDictMIDlet.d();
            b.e();
            b.repaint();
            return;
        }
    }

    private final String a;
    private final z b;
}
