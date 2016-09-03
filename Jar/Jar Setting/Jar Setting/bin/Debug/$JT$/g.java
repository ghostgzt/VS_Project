 

import java.io.PrintStream;
import java.util.*;
import javax.microedition.lcdui.*;
import javax.microedition.rms.RecordStore;
import javax.microedition.rms.RecordStoreException;

public final class g extends Canvas
    implements CommandListener, ItemStateListener
{
    class j extends TimerTask
    {

        public final void run()
        {
            g.a(a);
        }

        public final g a;

        public j()
        {
            a = g.this;
        }
    }


    public g()
    {
        L = new Command("返回", 2, 80);
        M = new Command("确定", 1, 70);
        n = new j(this);
        a();
        J = 0;
        y = false;
        B = false;
        String s1 = null;
        R = null;
        s = null;
        int i1 = 0;
        try
        {
            RecordStore recordstore;
            byte abyte0[] = (recordstore = RecordStore.openRecordStore("Option", false)).getRecord(1);
            recordstore.closeRecordStore();
            s1 = new String(abyte0);
            i1 = abyte0.length;
        }
        catch(RecordStoreException recordstoreexception)
        {
            System.out.println(recordstoreexception);
            if((s1 = JavaBook.b) != null)
                i1 = s1.length();
        }
        if(s1 != null)
        {
            int j1 = s1.indexOf('/', 1);
            int ai[];
            (ai = new int[6])[0] = j1;
            for(int l1 = 0; l1 < 5; l1++)
                ai[l1 + 1] = s1.indexOf('/', ai[l1] + 1);

            if(ai[0] != -1)
            {
                c = Integer.parseInt(s1.substring(0, ai[0]));
                d = Integer.parseInt(s1.substring(ai[0] + 1, ai[1]));
                e = Integer.parseInt(s1.substring(ai[1] + 1, ai[2]));
                f = Integer.parseInt(s1.substring(ai[2] + 1, ai[3]));
                h = Integer.parseInt(s1.substring(ai[3] + 1, ai[4]));
                g = Integer.parseInt(s1.substring(ai[4] + 1, i1));
            }
        } else
        {
            c = 0;
            d = 1;
            e = 0;
            f = 0;
            h = 9;
            g = 0;
        }
        D = q[c];
        E = r[d];
        F = e * 8;
        a = getWidth();
        b = getHeight();
        C = Font.getFont(0, 0, F);
        int k1 = C.stringWidth("快乐鸟大水") / 5;
        G = C.getHeight();
        j = (a / k1) * 2;
        i = b / G;
        I = a % k1;
        H = b % G;
        I /= 2;
        H /= 2;
        if(H < 2 && f == 1)
            H = 2;
        k = i * (j + 2) * 2;
        if(JavaBook.c == 3)
            b();
    }

    public final void a()
    {
        if(JavaBook.d)
        {
            System.out.println("0");
            try
            {
                boolean flag = false;
                setFullScreenMode(true);
                return;
            }
            catch(Exception _ex) { }
        }
    }

    private void b()
    {
        try
        {
            Class.forName("l");
            l.a(N);
            return;
        }
        catch(Exception _ex)
        {
            return;
        }
    }

    private void c()
    {
        try
        {
            Class.forName("l");
            l.b(N);
            return;
        }
        catch(Exception _ex)
        {
            return;
        }
    }

    private void d()
    {
        P = N.getCurrent();
        Q = P;
        x = new List("主菜单", 3);
        x.append("显示设置", null);
        x.append("页面跳转", null);
        x.append("新建书签", null);
        x.append("文字搜索", null);
        x.append("关于", null);
        x.append("返回目录", null);
        x.addCommand(L);
        x.setCommandListener(this);
        N.setCurrent(x);
    }

    public final void a(h h1)
    {
        R = h1;
        h1.a();
        t = new d();
        u = new b(h1.c);
        v = new p(h1.b, h1.c);
        S = new m();
    }

    public final void a(Display display, Displayable displayable, int i1)
    {
        N = display;
        O = displayable;
        N.setCurrent(this);
        b(i1);
    }

    private void e()
    {
        P = N.getCurrent();
        w = new List("跳转到...", 3);
        w.append("书签列表", null);
        w.append("快速翻页", null);
        w.append("自动翻页", null);
        w.append("本章开始", null);
        w.addCommand(L);
        w.setCommandListener(this);
        N.setCurrent(w);
    }

    private void f()
    {
        z = new Form("自定义:");
        A = new TextField("间隔:", Integer.toString(h), 2, 2);
        o = new ChoiceGroup(null, 2);
        if(JavaBook.c != 0)
        {
            o.append("背景灯亮", null);
            if(g == 1)
                o.setSelectedIndex(0, true);
        }
        z.append(o);
        z.append(A);
        z.addCommand(M);
        z.addCommand(L);
        z.setCommandListener(this);
        N.setCurrent(z);
    }

    private void g()
    {
        int i1 = (100 * s.a) / R.c;
        String s1 = "当前位置:" + Integer.toString(i1) + "%";
        z = new Form(s1);
        l = new Gauge("翻到:", true, 20, ((i1 / 10) * 10) / 5);
        z.append(l);
        z.addCommand(M);
        z.addCommand(L);
        z.setCommandListener(this);
        z.setItemStateListener(this);
        N.setCurrent(z);
    }

    private void h()
    {
        o.b = R.b;
        o.a = s.a;
        o.a();
        S.a(N);
        repaint();
    }

    private void i()
    {
        o.b = R.b;
        o.a = s.a;
        o.a();
        R.f();
        int i1 = o.b.length();
        String s1;
        int j1 = Integer.parseInt(s1 = o.b.substring(1, i1)) - 1;
        N.setCurrent(O);
        a.e.setSelectedIndex(j1, true);
        System.gc();
    }

    private void j()
    {
        s = R.d();
        repaint();
    }

    private void k()
    {
        s = R.c();
        repaint();
        J++;
        if(J > 5)
        {
            J = 0;
            o.b = R.b;
            o.a = s.a;
            o.a();
        }
    }

    private void b(int i1)
    {
        s = R.a(i1);
        repaint();
    }

    private void l()
    {
        n n1;
        (n1 = new n()).b = s.a;
        n1.a(s.c.substring(0, 10));
        u.a(n1, N, this);
    }

    private void m()
    {
        t.a(R, N, this);
    }

    public final void a(int i1)
    {
        b(i1);
    }

    private void n()
    {
        v.a(N, w, Q, this);
    }

    private void o()
    {
        P = N.getCurrent();
        L = new Command("返回", 2, 1);
        z = new Form("JBookReader");
        z.append("版本:" + JavaBook.a + "\n作者:快乐鸟大水\nBigwater.Org\nHappyBird.Org\n");
        z.addCommand(L);
        z.setCommandListener(this);
        N.setCurrent(z);
    }

    private String c(int i1)
    {
        if(i1 >= 10)
            return i1;
        else
            return "0" + i1;
    }

    private void p()
    {
        Calendar calendar = Calendar.getInstance();
        Date date = new Date();
        calendar.setTime(date);
        int i1 = calendar.get(7);
        String s1 = p[i1] + "\n";
        StringBuffer stringbuffer = new StringBuffer("");
        int j1;
        if((j1 = calendar.get(1)) == 1970)
        {
            stringbuffer = new StringBuffer("时间读取失败!\n请升级手机软件!");
        } else
        {
            stringbuffer.append("当前时间 ");
            stringbuffer.append(c(calendar.get(11)));
            stringbuffer.append(":");
            stringbuffer.append(c(calendar.get(12)));
            stringbuffer.append("\n");
            stringbuffer.append(Integer.toString(calendar.get(2) + 1));
            stringbuffer.append("月");
            stringbuffer.append(Integer.toString(calendar.get(5)));
            stringbuffer.append("日 ");
            stringbuffer.append(s1);
        }
        stringbuffer.append(h.a);
        long l1;
        l1 = (l1 = System.currentTimeMillis() - JavaBook.e) / 60000L;
        stringbuffer.append("\n阅读了:");
        stringbuffer.append(Long.toString(l1));
        stringbuffer.append("分钟\n");
        K = stringbuffer.toString();
        B = true;
        repaint();
    }

    public final void commandAction(Command command, Displayable displayable)
    {
        if(m != null)
        {
            m.cancel();
            m = null;
        }
        if(displayable == z && command == M)
        {
            if(z.get(0) == l)
            {
                N.setCurrent(Q);
                int i1 = (l.getValue() * 5 * R.c) / 100;
                b(i1);
            } else
            if(z.get(1) == A)
            {
                boolean flag = false;
                h = Integer.parseInt(A.getString());
                if(JavaBook.c != 0)
                    if(o.isSelected(0))
                        g = 1;
                    else
                        g = 0;
                m = new Timer();
                n = new j(this);
                try
                {
                    m.schedule(n, h * 1000, h * 1000);
                }
                catch(IllegalArgumentException _ex)
                {
                    z.setTitle("请输入大于0的数字");
                }
                N.setCurrent(Q);
                S.a();
                if(JavaBook.c != 0)
                    if(g == 1)
                        b();
                    else
                        c();
            }
            z = null;
            System.gc();
        }
        int j1;
        if(displayable == w && command == List.SELECT_COMMAND)
            switch(j1 = w.getSelectedIndex())
            {
            case 0: // '\0'
                n();
                break;

            case 1: // '\001'
                g();
                break;

            case 2: // '\002'
                f();
                break;

            case 3: // '\003'
                w = null;
                System.gc();
                N.setCurrent(Q);
                b(0);
                break;
            }
        if(displayable == x && command == List.SELECT_COMMAND)
            switch(j1 = x.getSelectedIndex())
            {
            case 0: // '\0'
                h();
                break;

            case 1: // '\001'
                e();
                break;

            case 2: // '\002'
                l();
                break;

            case 3: // '\003'
                m();
                break;

            case 4: // '\004'
                o();
                break;

            case 5: // '\005'
                i();
                break;
            }
        if(command == L)
        {
            if(displayable != x)
                N.setCurrent(P);
            if(displayable == x || displayable == z)
                N.setCurrent(Q);
            System.gc();
        }
    }

    public final void keyPressed(int i1)
    {
        if(m != null && i1 != 48 && i1 != 42 && i1 != 35)
        {
            m.cancel();
            m = null;
        }
        switch(getGameAction(i1))
        {
        case 1: // '\001'
        case 2: // '\002'
            i1 = 50;
            break;

        case 5: // '\005'
        case 6: // '\006'
            i1 = 54;
            break;

        case 8: // '\b'
            d();
            break;
        }
        switch(i1)
        {
        case 36: // '$'
        case 37: // '%'
        case 38: // '&'
        case 39: // '\''
        case 40: // '('
        case 41: // ')'
        case 43: // '+'
        case 44: // ','
        case 45: // '-'
        case 46: // '.'
        case 47: // '/'
        default:
            break;

        case 48: // '0'
            return;

        case 49: // '1'
            p();
            return;

        case 50: // '2'
        case 52: // '4'
            j();
            return;

        case 54: // '6'
        case 56: // '8'
            k();
            return;

        case 51: // '3'
            n();
            return;

        case 53: // '5'
            l();
            return;

        case 55: // '7'
            P = Q;
            g();
            return;

        case 57: // '9'
            m();
            return;

        case 42: // '*'
            if(m == null)
            {
                m = new Timer();
                n = new j(this);
                m.schedule(n, h * 1000, h * 1000);
            }
            if(JavaBook.c != 0)
                if(g == 1)
                {
                    b();
                    return;
                } else
                {
                    c();
                    return;
                }
            break;

        case 35: // '#'
            if(JavaBook.c == 0)
                break;
            if(y)
            {
                b();
                y = false;
                return;
            }
            c();
            y = true;
            break;
        }
    }

    public final void keyReleased(int i1)
    {
        switch(i1)
        {
        case 49: // '1'
            B = false;
            repaint();
            System.gc();
            break;
        }
    }

    public final void keyRepeated(int i1)
    {
        switch(i1)
        {
        default:
            keyPressed(i1);
            return;

        case 49: // '1'
            repaint();
            break;
        }
    }

    public final void pointerPressed(int i1, int j1)
    {
        if(j1 < getHeight() / 2)
        {
            j();
            return;
        } else
        {
            k();
            return;
        }
    }

    public final void a(n n1)
    {
        v.a(n1);
    }

    public final void b(n n1)
    {
        b(n1.b);
    }

    public final void paint(Graphics g1)
    {
        System.gc();
        g1.setColor(D);
        g1.fillRect(0, 0, a, b);
        if(R == null || R.c == 0 || s == null || s.c == null)
        {
            g1.setColor(0);
            g1.drawString("Error!", 0, 0, 20);
            return;
        }
        if(f == 1)
        {
            int i1 = (a * s.a) / R.c;
            g1.setColor(0xe0e0e0);
            g1.setStrokeStyle(1);
            g1.drawLine(0, 0, a, 0);
            g1.drawLine(1, 1, a, 1);
            g1.setColor(255);
            g1.fillRect(0, 0, i1, 2);
            g1.setColor(0xff0000);
            g1.setStrokeStyle(0);
            if(v != null)
            {
                for(int l1 = 0; l1 < v.a(); l1++)
                {
                    n n1 = v.a(l1);
                    int l2 = (a * n1.b) / R.c;
                    g1.drawLine(l2, 0, l2, 3);
                }

            }
        } else
        if(f == 0)
        {
            int j1 = (b * s.a) / R.c;
            g1.setColor(0xe0e0e0);
            g1.setStrokeStyle(1);
            g1.drawLine(a - 2, 0, a - 2, b);
            g1.drawLine((a - 2) + 1, 1, (a - 2) + 1, b);
            g1.setColor(255);
            g1.fillRect(a - 2, 0, a, j1);
            g1.setColor(0xff0000);
            g1.setStrokeStyle(0);
            if(v != null)
            {
                for(int i2 = 0; i2 < v.a(); i2++)
                {
                    n n2 = v.a(i2);
                    int i3 = (b * n2.b) / R.c;
                    g1.drawLine(a - 3, i3, a, i3);
                }

            }
        }
        g1.setColor(E);
        g1.setFont(C);
        int k1 = 0;
        int j2 = 0;
        if(!B)
            K = s.c;
        for(int k2 = K.length(); k1 < k2 && j2 < i;)
        {
            int j3 = 0;
            StringBuffer stringbuffer = new StringBuffer("");
            while(k1 < k2 && j3 < j - 1) 
            {
                char c1;
                if((c1 = K.charAt(k1++)) == '\r')
                    continue;
                if(c1 == '\n')
                    break;
                stringbuffer.append(c1);
                if(c1 > 0 && c1 < '\u0100')
                    j3++;
                else
                    j3 += 2;
            }
            if(stringbuffer.length() > 0)
            {
                g1.drawString(stringbuffer.toString(), I, j2 * G + H, 20);
                j2++;
            }
        }

    }

    public final void itemStateChanged(Item item)
    {
        if(item == l)
            l.setLabel("翻到:" + Integer.toString(l.getValue() * 5) + "%");
    }

    public static final void a(g g1)
    {
        g1.k();
    }

    private ChoiceGroup o;
    private String p[] = {
        "周六", "周日", "周一", "周二", "周三", "周四", "周五"
    };
    private int q[] = {
        0xffffff, 0, 0xc0c0c0, 49152, 192, 0xc00000, 49344, 0xc0c000
    };
    private int r[] = {
        0xffffff, 0, 0xc0c0c0, 0xe0e0e0, 49152, 65280, 192, 255, 0xc00000, 0xff0000, 
        49344, 65535, 0xc0c000, 0xffff00, 0xc000c0, 0xff00ff
    };
    private i s;
    private d t;
    private b u;
    private p v;
    private List w;
    private List x;
    private boolean y;
    private Form z;
    private TextField A;
    private boolean B;
    private Font C;
    public static int a;
    public static int b;
    private int D;
    private int E;
    private int F;
    public static int c;
    public static int d;
    public static int e;
    public static int f;
    public static int g;
    public static int h;
    public static int i;
    public static int j;
    public static int k;
    private int G;
    private int H;
    private int I;
    private int J;
    private String K;
    private Command L;
    private Command M;
    private Display N;
    private Displayable O;
    private Displayable P;
    private Displayable Q;
    private h R;
    private m S;
    public Gauge l;
    public Timer m;
    public j n;
}
