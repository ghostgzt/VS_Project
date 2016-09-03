 

import java.io.*;
import java.util.*;
import javax.microedition.io.Connector;
import javax.microedition.io.file.FileConnection;
import javax.microedition.io.file.FileSystemRegistry;
import javax.microedition.lcdui.*;
import javax.microedition.media.*;
import javax.microedition.midlet.MIDlet;
import javax.microedition.rms.*;

public class MemoDictMIDlet extends MIDlet
    implements CommandListener
{

    public MemoDictMIDlet()
    {
    }

    public void startApp()
    {
        if(_D_D == 0)
        {
            z z1 = new z(this, 0);
            z1._e();
            _D_D++;
        } else
        {
            _d_d();
        }
    }

    public void pauseApp()
    {
    }

    public void destroyApp(boolean flag)
    {
        if(a == -1)
        {
            l();
            m();
        }
    }

    private void ea()
    {
        dj = v.getWidth();
        if((dk = v.getHeight()) < v.a)
            dk = v.a;
        if(i != 0)
        {
            int i1 = dj;
            dj = dk;
            dk = i1;
        }
        F = dj / 50;
        if(v.hasPointerEvents())
        {
            if((F <<= 1) > 16)
                F = 16;
        } else
        if(F > 8)
            F = 8;
        try
        {
            dl = (di = Image.createImage(dj, dk)).getGraphics();
        }
        catch(Exception exception)
        {
            a("ci", exception);
        }
        ai(cE);
        if(cZ == 0)
        {
            be = aW;
            bf = aY;
        } else
        {
            be = aY;
            bf = aW;
        }
        a();
    }

    public final void a()
    {
        bF = null;
        bF = new o(dA, dl, dw, dx, dy, dz, dn, dd, 0);
        if(cc.b == 'J')
            bF.d("词典", 3);
        else
            bF.d("浏览词汇", 3);
        bF.d("课件", 9);
        bF.d("背单词", 4);
        bF.d("复习", 5);
        bF.d("我的单词", 6);
        bF.d("设置", 7);
        bF.d("关于", 8);
        bF.a("", bb);
        bF.h(0);
        bF.z = true;
        int i1 = dz;
        if(aH)
            i1 -= fm * 3;
        ce = null;
        ce = new o(null, dl, dw, dx, dy, i1, dn, dd, 3);
        ce.a(aV, aX);
        bU = null;
        (bU = new o("选择词库", dl, dw, dx, dy, dz, dn, dd, 0)).a("选择词库");
        bl = bU.d();
        for(int j1 = 0; j1 < 10; j1++)
            bU.d(aN[j1]);

        bU.a("每组单词数");
        bm = bU.d();
        bU.e(Integer.toString(cz));
        bU.a(be, bf);
        bU.z = true;
        bU.a("学习顺序");
        bn = bU.d();
        bU.d("顺序");
        bU.d("倒序");
        bU.d("乱序");
        bU.h(1);
        (bw = new TextBox("编辑", "", 255, 0)).addCommand(bh);
        bw.addCommand(bg);
        bw.setCommandListener(this);
        (ee = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ee.a(es, et);
        ee.a();
        (ef = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ef.a(eu, ev);
        ef.a();
        (eh = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        eh.a(ew, ex);
        eh.a();
        (ei = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ei.a(ey, ez);
        ei.a();
        (ej = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ej.a(eA, eB);
        ej.a();
        (el = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        el.a(eE, eF);
        el.a();
        (en = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        en.a(eG, eH);
        en.a();
        (eo = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        eo.a(eI, eJ);
        eo.a();
        (ep = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ep.a(eK, eL);
        ep.a();
    }

    static void b()
    {
        bW = null;
        (bW = new o("浏览方式设置", dl, dw, dx, dy, dz, dn, dd, 0)).a("浏览方式");
        bz = bW.d();
        bW.d("手动");
        bW.d("自动");
        bW.d("拼写");
        bW.d("测试");
        bW.d("列表");
        bW.a("背单词提示方式");
        by = bW.d();
        bW.d("英-汉");
        bW.d("汉-英");
        bW.a("自动浏览速度");
        bA = bW.d();
        bW.d("快速");
        bW.d("正常");
        bW.d("慢速");
        bW.a(be, bf);
        if(cm == 2 || cm == 3 || cm == 4)
        {
            bW.a("辅助功能");
            bB = bW.d();
            bW.c("自动查当前词典");
            boolean flag = false;
            if(cm == 2 && cI != 0)
                flag = true;
            else
            if(cm == 3 && cM != 0)
                flag = true;
            else
            if(cm == 4 && cQ != 0)
                flag = true;
            bW.a(bB, flag);
            if(cm == 2)
            {
                bW.c("隐藏已掌握单词");
                if(da != 0)
                    bW.a(bB + 1, true);
            }
        }
        bW.z = true;
    }

    private static void eb()
    {
        try
        {
            B = (new int[] {
                7, 0, 0, 0, 0, 8, 28, 62, 127, 62, 
                28, 8, 0, 0, 0, 0, 0, 8, 0, 0, 
                0, 0, 60, 70, 6, 6, 62, 102, 198, 198, 
                123, 0, 0, 0, 8, 0, 192, 192, 192, 220, 
                230, 195, 195, 195, 195, 195, 230, 220, 0, 0, 
                0, 7, 0, 0, 0, 0, 124, 6, 3, 3, 
                3, 3, 3, 6, 124, 0, 0, 0, 8, 0, 
                3, 3, 3, 59, 103, 195, 195, 195, 195, 195, 
                103, 59, 0, 0, 0, 8, 0, 0, 0, 0, 
                60, 102, 195, 195, 255, 192, 192, 96, 31, 0, 
                0, 0, 5, 0, 7, 12, 12, 31, 12, 12, 
                12, 12, 12, 12, 12, 12, 0, 0, 0, 8, 
                0, 0, 0, 0, 59, 103, 195, 195, 195, 195, 
                195, 103, 59, 3, 6, 124, 8, 0, 96, 96, 
                96, 110, 115, 99, 99, 99, 99, 99, 99, 99, 
                0, 0, 0, 4, 0, 6, 0, 0, 6, 6, 
                6, 6, 6, 6, 6, 6, 6, 0, 0, 0, 
                4, 0, 3, 0, 0, 3, 3, 3, 3, 3, 
                3, 3, 3, 3, 3, 3, 14, 8, 0, 96, 
                96, 96, 97, 98, 100, 104, 120, 108, 102, 99, 
                97, 0, 0, 0, 4, 0, 6, 6, 6, 6, 
                6, 6, 6, 6, 6, 6, 6, 6, 0, 0, 
                0, 13, 0, 0, 0, 0, 3534, 3699, 3171, 3171, 
                3171, 3171, 3171, 3171, 3171, 0, 0, 0, 8, 0, 
                0, 0, 0, 222, 227, 195, 195, 195, 195, 195, 
                195, 195, 0, 0, 0, 7, 0, 0, 0, 0, 
                124, 6, 3, 3, 127, 99, 99, 54, 28, 0, 
                0, 0, 8, 0, 0, 0, 0, 220, 230, 195, 
                195, 195, 195, 195, 230, 220, 192, 192, 192, 8, 
                0, 60, 102, 66, 195, 195, 255, 195, 195, 195, 
                98, 102, 60, 0, 0, 0, 6, 0, 0, 0, 
                0, 27, 28, 24, 24, 24, 24, 24, 24, 24, 
                0, 0, 0, 6, 0, 0, 0, 0, 30, 48, 
                48, 56, 30, 7, 3, 35, 30, 0, 0, 0, 
                5, 0, 0, 12, 12, 31, 12, 12, 12, 12, 
                12, 12, 12, 7, 0, 0, 0, 8, 0, 0, 
                0, 0, 195, 195, 195, 195, 195, 195, 195, 199, 
                123, 0, 0, 0, 8, 0, 0, 0, 0, 193, 
                98, 98, 98, 52, 52, 52, 24, 24, 0, 0, 
                0, 11, 0, 0, 0, 0, 1585, 1585, 858, 858, 
                858, 858, 858, 396, 396, 0, 0, 0, 4, 0, 
                1, 3, 6, 4, 12, 12, 12, 12, 12, 12, 
                4, 6, 3, 1, 0, 4, 0, 8, 12, 6, 
                2, 3, 3, 3, 3, 3, 3, 2, 6, 12, 
                8, 0, 7, 0, 0, 0, 0, 127, 3, 6, 
                12, 12, 24, 48, 96, 127, 0, 0, 0, 12, 
                0, 0, 0, 0, 988, 1142, 99, 99, 1023, 3680, 
                3168, 3184, 1951, 0, 0, 0, 8, 0, 0, 0, 
                0, 24, 24, 44, 44, 44, 70, 70, 70, 131, 
                0, 0, 0, 6, 0, 0, 0, 0, 31, 48, 
                48, 24, 14, 48, 48, 48, 31, 0, 0, 0, 
                8, 8, 240, 56, 76, 62, 102, 195, 195, 195, 
                195, 195, 102, 60, 0, 0, 0, 7, 0, 15, 
                24, 24, 24, 24, 24, 24, 24, 24, 24, 24, 
                24, 24, 24, 112, 7, 0, 0, 0, 0, 127, 
                2, 4, 8, 16, 60, 6, 3, 3, 3, 6, 
                124, 8, 0, 0, 0, 0, 110, 115, 99, 99, 
                99, 99, 99, 99, 99, 3, 3, 14, 3, 0, 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 0, 3, 0, 2, 2, 2, 
                2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 0, 6, 6, 2, 4, 0, 4, 
                0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 
                0, 0, 6, 0, 0, 0, 4, 0, 0, 0, 
                0, 6, 0, 0, 0, 0, 0, 0, 0, 6, 
                2, 4, 0, 7, 0, 0, 0, 0, 0, 0, 
                0, 0, 127, 0, 0, 0, 0, 0, 0, 0, 
                3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                0, 0, 0, 2, 2, 2, 2
            });
            E = Image.createImage("/icon/search.png");
            D = Image.createImage("/icon/cursor.png");
            String as1[] = {
                "", "dir.png", "file.png", "dict.png", "memo.png", "review.png", "note.png", "option.png", "about.png", "course.png", 
                "online.png", "Document.png", "Music.png", "Movie.png"
            };
            for(int i1 = 1; i1 < 14; i1++)
                C[i1] = Image.createImage("/icon/" + as1[i1]);

            return;
        }
        catch(Exception exception)
        {
            a("rs", exception);
        }
    }

    private static void ai(int i1)
    {
        switch(i1)
        {
        case 0: // '\0'
            dl.setFont(Font.getFont(0, 0, 16));
            break;

        case 1: // '\001'
            dl.setFont(Font.getFont(0, 0, 0));
            break;

        default:
            dl.setFont(Font.getFont(0, 0, 8));
            break;
        }
        if((i1 = (dm = dl.getFont()).getHeight()) < 16)
            dn = 16;
        else
            dn = i1;
        _flddo = 0;
        dp = 0;
        dq = dj;
        ds = 0;
        du = dj;
        if(dk <= 128 && dn >= 20)
            de = 1;
        if(de == 0)
        {
            dr = dn + 2;
            dv = dn + 2;
        } else
        {
            dr = --dn;
            dv = dn;
        }
        dt = dk - dv;
        dw = 2;
        dx = dr;
        dy = dj - dw;
        dz = dk - dr - dv;
        X = dn >> 1;
        Y = dn >> 1;
        Z = (dn << 1) / 3;
        aa = dn;
        for(int j1 = 0; j1 < fk.length; j1 += 2)
        {
            char c1 = fk[j1];
            dm.charWidth(c1);
        }

        fm = i1 + 2;
        fl = dy / 12;
        if(fm < fl)
            fm = fl;
        fl = (fl + 1) / 2;
    }

    final void c()
    {
        cf = null;
        cf = new o(null, dl, dw, dx, dy, dz, dn, dd, 0);
        if(ec.size() > 0)
        {
            for(int i1 = 0; i1 < ec.size(); i1++)
            {
                Object obj = (w)ec.elementAt(i1);
                obj = ((w) (obj)).a + " (" + ((w) (obj)).b + ")";
                cf.f(((String) (obj)));
            }

            cf.h(ed);
            cf.i(ed);
        }
        cf.z = true;
        cf.a(aV, aX);
    }

    static void d()
    {
        bK = null;
        (bK = new o("词典管理", dl, dw, dx, dy, dz, dn, dd, 0)).a(aV, aX);
        for(int i1 = 0; i1 < eg.size(); i1++)
        {
            ai ai1 = (ai)eg.elementAt(i1);
            bK.f((i1 + 1) + "." + " " + ai1.a);
        }

        if(bL < 0 || bL >= eg.size())
            bL = 0;
        bK.h(bL);
        bK.i(bL);
        bK.z = true;
        f = bK;
    }

    static void e()
    {
        bN = null;
        (bN = new o("课件", dl, dw, dx, dy, dz, dn, dd, 0)).a(aV, aX);
        if(em.size() > 0)
        {
            if(bO < 0 || bO >= em.size())
                bO = 0;
            ag ag1;
            byte byte0 = (ag1 = (ag)em.elementAt(bO)).c;
            int i1 = bO;
            ag ag2;
            for(int j1 = bO - 1; j1 >= 0 && (ag2 = (ag)em.elementAt(j1)).c >= byte0; j1--)
                if(ag2.c == byte0)
                    i1 = j1;

            int k1 = 0;
            int l1 = 0;
            ag ag3;
            for(i1 = i1; i1 < em.size() && (ag3 = (ag)em.elementAt(i1)).c >= byte0; i1++)
            {
                if(ag3.c > byte0)
                    continue;
                if(i1 == bO)
                    k1 = l1;
                l1++;
                String s1 = ag3.b.toLowerCase();
                byte byte1 = -1;
                if(s1.endsWith(".jyb") || s1.endsWith(".lrc") || s1.endsWith(".mbk") || s1.endsWith(".txt"))
                    byte1 = 11;
                else
                if(s1.endsWith("/"))
                    byte1 = 1;
                else
                if(s1.endsWith(".mp3") || s1.endsWith(".amr") || s1.endsWith(".wav") || s1.endsWith(".aac"))
                    byte1 = 12;
                else
                if(s1.endsWith(".3gp"))
                    byte1 = 13;
                bN.a(ag3.a, byte1, i1);
            }

            bN.h(k1);
            bN.i(k1);
        } else
        {
            bN.a("请添加需要学习的课件");
        }
        bN.z = true;
        f = bN;
    }

    public void commandAction(Command command, Displayable displayable)
    {
label0:
        {
label1:
            {
label2:
                {
label3:
                    {
label4:
                        {
label5:
                            {
                                command.getLabel();
                                if(displayable != bw)
                                    break label0;
                                if(command != bg)
                                    break label1;
                                command = bw.getString();
                                if(bx == 'U')
                                {
                                    f.a(er, command);
                                    if(f == p)
                                        fs = command;
                                    break label2;
                                }
                                if(bx == 'C')
                                {
                                    if(cn)
                                        f = ce;
                                    else
                                        f = ci;
                                    cb.setCurrent(v);
                                    v.setFullScreenMode(true);
                                    a(false, command);
                                    return;
                                }
                                if(bx != 'T')
                                    break label3;
                                cb.setCurrent(v);
                                v.setFullScreenMode(true);
                                if(ah == null)
                                    break label4;
                                dI.b = -1L;
                                Command command1 = command;
                                displayable = ah;
                                long l2 = a.a(command1);
                                int i1 = 0;
                                int k1 = ((s) (displayable)).e;
                                if(((s) (displayable)).d != null && ((s) (displayable)).d.C)
                                {
                                    i1 = (int)(l2 / 1000L);
                                    int l1 = -1;
                                    for(int j2 = 0; j2 < ((s) (displayable)).d.k; j2++)
                                        if(l1 < 0 && i1 < ((s) (displayable)).d.t[j2])
                                            l1 = j2;

                                    if(l1 == -1)
                                    {
                                        k1 = i1 = ((s) (displayable)).e - 1;
                                    } else
                                    {
                                        if(l1 == 0)
                                            i1 = 0;
                                        else
                                            i1 = ((s) (displayable)).d.o[l1 - 1];
                                        k1 = ((s) (displayable)).d.o[l1];
                                    }
                                }
                                i1 = i1;
                                do
                                {
                                    if(i1 >= k1)
                                        break;
                                    displayable.b(i1);
                                    if(((s) (displayable)).x != null)
                                    {
                                        int i2 = ((s) (displayable)).x.indexOf("-");
                                        String s1;
                                        long l3 = a.a(s1 = ((s) (displayable)).x.substring(i2 + 1, ((s) (displayable)).x.length()));
                                        if(l2 < l3)
                                        {
                                            displayable = i1;
                                            break label5;
                                        }
                                    }
                                    i1++;
                                } while(true);
                                displayable = k1 - 1;
                            }
                            int j1 = displayable;
                            displayable = ah;
                            ah.r = j1;
                            ah.b(ah.r);
                        }
                        i(command);
                        if(ah != null)
                        {
                            I();
                            if(ah.x != null)
                                dI.a(ah.x);
                            v.e();
                            v.repaint();
                        }
                        if(dK == 3)
                            G();
                        return;
                    }
                    if(bx == 'E')
                    {
                        if(eb == 1)
                        {
                            (displayable = (w)ec.elementAt(ed)).a = command;
                            c();
                            f = cf;
                        } else
                        {
                            Vector vector = ((w) (displayable = (w)ec.elementAt(ed))).c;
                            command = command;
                            vector.setElementAt(command, ((w) (displayable)).d);
                            g(command);
                            if(cN == 4)
                            {
                                ak(0);
                            } else
                            {
                                cr = true;
                                v.f();
                            }
                        }
                    } else
                    if(eb == 1)
                    {
                        x(command);
                        c();
                        f = cf;
                    } else
                    {
                        if(a(ed, command) == 0)
                            g(command);
                        else
                            d("添加的单词本中已有 " + command);
                        if(cN == 4)
                        {
                            ak(0);
                        } else
                        {
                            cr = true;
                            v.f();
                        }
                    }
                }
                cb.setCurrent(v);
                v.setFullScreenMode(true);
                v.e();
                v.repaint();
                return;
            }
            if(command == bh)
            {
                if(cm == 1 && f == ce && cn && G == 1)
                    r();
                cb.setCurrent(v);
                v.setFullScreenMode(true);
                v.e();
                v.repaint();
                return;
            }
        }
    }

    private void aj(int i1)
    {
        for(int j1 = 0; j1 < ce.d(); j1++)
        {
            int k1;
            if((k1 = i1 + j1) < cd.e)
            {
                cd.c(k1);
                s s1;
                ce.a(j1, k1, (s1 = cd).m);
            } else
            {
                ce.a(j1, -1, "");
            }
        }

        i1 = i1;
        s s2 = cd;
        cd.r = i1;
        ce.h(0);
    }

    private void ak(int i1)
    {
        cj = null;
        (cj = new o(null, dl, dw, dx, dy, dz, dn, dd, 0)).a(aV, aX);
        cj.s = 0;
        Vector vector = null;
        int j1 = dG;
        int k1 = 0;
        int l1 = cj.r;
        fj = new Vector();
        if(cm == 2)
        {
            j1 = dG;
            k1 = i1;
        } else
        if(cm == 3)
        {
            j1 = dC.length;
            k1 = dW;
        } else
        if(cm == 4)
        {
            j1 = ((w) (i1 = (w)ec.elementAt(ed))).b;
            k1 = ((w) (i1)).d;
            vector = ((w) (i1)).c;
            if(cN == 4)
            {
                fg = "";
                fh = -1;
                dN = -1;
            }
        }
        do
        {
            if(k1 >= j1)
                break;
            if(cm == 2)
            {
                i1 = cy[k1];
                int j2 = i1;
                s s1 = cc;
                cc.r = j2;
                cc.a(i1);
            } else
            if(cm == 3)
            {
                if((dC[k1] & 0x80) == 0)
                {
                    k1++;
                    continue;
                }
                int k2 = k1;
                s s2 = cc;
                cc.r = k2;
                cc.a(k1);
            } else
            if(cm == 4)
            {
                i1 = (String)vector.elementAt(k1);
                g(i1);
            }
            i1 = cj.y;
            int i2 = cj.n.size();
            if(cs == 0)
                cj.e(cc.m, k1);
            else
                cj.e(cc.o, k1);
            fj.addElement(new af(k1, cj.n.size() - i2, cj.y - i1));
            if(k1 + 1 >= j1 || cj.y >= l1)
                break;
            k1++;
        } while(true);
        if(cj.n.size() > 0)
            cj.i(0);
        f = cj;
        v.e();
        v.repaint();
        v.serviceRepaints();
    }

    private void a(boolean flag, String s1)
    {
        boolean flag1 = false;
        if(s1.length() == 0)
        {
            if(cn)
            {
                f = ce;
                r();
            } else
            {
                f = ci;
            }
            v.e();
            v.repaint();
            return;
        }
        int i1 = 0;
        do
        {
            if(i1 >= dQ)
                break;
            if(s1.compareTo((String)dR.elementAt(i1)) == 0)
            {
                flag1 = true;
                dR.removeElementAt(i1);
                break;
            }
            i1++;
        } while(true);
        dR.insertElementAt(s1, 0);
        if(!flag1)
            dQ++;
        if(flag)
        {
            G = 2;
            cg = true;
        } else
        if(s1.indexOf("*") >= 0)
        {
            G = 3;
            cg = true;
        } else
        {
            G = 1;
        }
        if(G == 1)
        {
            co = false;
            cq = s1;
        } else
        {
            co = true;
            cn = true;
            cq = s1;
        }
        (new Thread(new q(this))).start();
    }

    public static void f()
    {
        bC = null;
        (bC = new o("词典", dl, dw, dx, dy, dz, dn, dd, 0)).a("输入查询单词");
        bZ = bC.d();
        bC.e("");
        bC.a("查词", 11, "搜索", 12);
        if(dQ > 0)
        {
            bC.a("最近查询单词");
            ca = bC.d();
            for(int i1 = 0; i1 < dQ; i1++)
                bC.d((String)dR.elementAt(i1));

            bC.b("清除历史查询", 13);
        }
        bC.a(aV, aX);
        bC.h(1);
        f = bC;
        v.e();
        v.repaint();
    }

    private static int t(String s1)
    {
        for(int i1 = 0; i1 < fv.length; i1 += 2)
            if(s1.compareTo(fv[i1]) == 0)
                return i1 >> 1;

        return -1;
    }

    public static void g()
    {
        p = null;
        (p = new o("翻译", dl, dw, dx, dy, dz, dn, dd, 0)).a("输入内容");
        bE = p.d();
        p.e(fs);
        p.a("翻译", 14, "互换", 17);
        p.a("源语言");
        if((fr = t(fq)) == -1)
        {
            fr = 0;
            fq = fv[fr << 1];
        }
        if((fu = t(ft)) == -1)
        {
            fu = 1;
            ft = fv[fu << 1];
        }
        p.f(fv[(fr << 1) + 1], 14);
        p.a("目标语言");
        p.f(fv[(fu << 1) + 1], 15);
        p.a("翻译结果");
        p.a(L);
        p.a(aV, aX);
        p.h(1);
        f = p;
        v.e();
        v.repaint();
    }

    public final void h()
    {
        bS = null;
        (bS = new o("选择复习", dl, dw, dx, dy, dz, dn, dd, 0)).a("根据遗忘曲线复习");
        bG = bS.d();
        for(int i1 = 0; i1 < 16; i1++)
            dU[i1] = 0;

        for(int j1 = 0; j1 < dC.length; j1++)
        {
            int l1;
            if((l1 = dC[j1] >> 3 & 0xf) != 0)
                dU[l1]++;
        }

        Calendar.getInstance();
        dY.getTime();
        this = 0;
        for(int k1 = 2; k1 < 15; k1++)
            this += dU[k1];

        bS.c("最近新学的词(" + dU[1] + ")");
        bS.c("已到时间的词(" + this + ")");
        bS.c("总记不住的词(" + dU[15] + ")");
        bS.a("选择熟悉程度复习");
        bH = bS.d();
        ef();
        bS.c("1级初学的词(" + dE[1] + ")");
        bS.c("2级见过的词(" + dE[2] + ")");
        bS.c("3级模糊的词(" + dE[3] + ")");
        bS.c("4级认识的词(" + dE[4] + ")");
        bS.c("5级掌握的词(" + dE[5] + ")");
        bS.a(be, bf);
        bS.z = true;
        bS.h(1);
        f = bS;
        v.e();
        v.repaint();
    }

    public final void i()
    {
        if(cm == 1 && cd.b != 'J')
        {
            v.f();
            v.e();
            v.repaint();
            return;
        }
        if(dM != 0)
        {
            return;
        } else
        {
            (new Thread(new r(this))).start();
            return;
        }
    }

    public static String a(int i1)
    {
        String s1;
        s1 = "";
        if(i1 < 0)
            return s1;
        FileConnection fileconnection;
        if(R != null)
            break MISSING_BLOCK_LABEL_342;
        try
        {
            int j1 = 1;
            String s3 = aR + "dict.dat";
            Object obj = null;
            Object obj2 = null;
            XConnection xconnection = new XConnection();
            if(s3.startsWith("sms"))
                obj2 = xconnection;
            else
                obj2 = Connector.open(s3, j1);
            fileconnection = (FileConnection)obj2;
            break MISSING_BLOCK_LABEL_126;
        }
        // Misplaced declaration of an exception variable
        catch(int i1)
        {
            d("错误:" + i1.toString() + "\n无法访问文件,请检查是否设置好文件访问权限,及存贮卡是否已被取出");
        }
        return "";
        if(fileconnection.exists())
        {
            R = new a(aR + "dict.dat");
            break MISSING_BLOCK_LABEL_319;
        }
        int k1 = 1;
        String s4 = aR + "example/";
        Object obj1 = null;
        Object obj3 = null;
        XConnection xconnection1 = new XConnection();
        if(s4.startsWith("sms"))
            obj3 = xconnection1;
        else
            obj3 = Connector.open(s4, k1);
        if((fileconnection = (FileConnection)obj3).exists())
        {
            R = new a(aR + "example/dat0");
            break MISSING_BLOCK_LABEL_319;
        }
        d("未在目录" + aR + "内找到例句文件");
        return "";
        String s2;
        if((s2 = R.a(true)) == null)
            break MISSING_BLOCK_LABEL_342;
        d(s2);
        R = null;
        return "";
        try
        {
            s1 = R.b(i1);
        }
        catch(Exception exception)
        {
            a("rt", exception);
        }
        return s1;
    }

    public final boolean j()
    {
        if(cm == 1)
            this = cd;
        else
            this = cc;
        int i1 = super.r;
        int j1 = cB;
        if(super.d == null)
            return true;
        if(cm == 2)
        {
            do
            {
                if(++j1 >= dG)
                    return true;
                i1 = cy[j1];
            } while((dC[i1] & 7) >= 5 && da != 0);
            cB = j1;
            super.r = cy[cB];
            a(super.r);
            return false;
        }
        do
        {
            if(++i1 >= super.e)
            {
                if(cm != 3)
                    break;
                i1 = 0;
            }
            if(cm == 3 && dC[i1] >= 0)
            {
                if(i1 == super.r)
                {
                    dV = 0;
                    a(super.r);
                    return true;
                }
            } else
            {
                super.r = i1;
                a(super.r);
                return false;
            }
        } while(true);
        cB = j1;
        a(super.r);
        return true;
    }

    public final boolean k()
    {
        if(cm == 1)
            this = cd;
        else
            this = cc;
        int i1 = super.r;
        int j1 = cB;
        if(super.d == null)
            return true;
        if(cm == 2)
        {
            do
            {
                if(--j1 < 0)
                    return true;
                i1 = cy[j1];
            } while((dC[i1] & 7) >= 5 && da != 0);
            cB = j1;
            super.r = cy[cB];
            a(super.r);
            return false;
        }
        do
        {
            if(--i1 < 0)
            {
                if(cm != 3)
                    break;
                i1 = super.e - 1;
            }
            if(cm == 3 && dC[i1] >= 0)
            {
                if(i1 == super.r)
                {
                    dV = 0;
                    a(super.r);
                    return true;
                }
            } else
            {
                super.r = i1;
                a(super.r);
                return false;
            }
        } while(true);
        cB = j1;
        a(super.r);
        return true;
    }

    private String u(String s1)
    {
        this = new byte[8];
        for(int i1 = 0; i1 < s1.length(); i1++)
            this[i1 % 8] += s1.charAt(i1) & 0xf;

        for(int j1 = 0; j1 < 8; j1++)
            this[j1] &= 0xf;

        return a(this[0] + (this[1] << 4) + (this[2] << 8) + (this[3] << 12), 5) + a(this[7] + (this[6] << 4) + (this[5] << 8) + (this[4] << 12), 5);
    }

    private void al(int i1)
    {
        switch(i1)
        {
        case 0: // '\0'
            I = q;
            return;

        case 1: // '\001'
            I = r;
            return;

        case 2: // '\002'
            I = s;
            return;
        }
        I = t;
    }

    final int l()
    {
        if(bk == null)
            return 0;
        byte abyte0[];
        try
        {
            abyte0 = ec();
        }
        catch(OutOfMemoryError _ex)
        {
            return 3;
        }
        try
        {
            bk.setRecord(1, abyte0, 0, abyte0.length);
        }
        catch(InvalidRecordIDException _ex)
        {
            try
            {
                bk.addRecord(abyte0, 0, abyte0.length);
            }
            catch(RecordStoreException _ex2)
            {
                return 1;
            }
        }
        catch(RecordStoreException _ex)
        {
            return 2;
        }
        try
        {
            abyte0 = ed();
        }
        catch(OutOfMemoryError _ex)
        {
            return 3;
        }
        try
        {
            bk.setRecord(2, abyte0, 0, abyte0.length);
        }
        catch(InvalidRecordIDException _ex)
        {
            try
            {
                bk.addRecord(abyte0, 0, abyte0.length);
            }
            catch(RecordStoreException _ex2)
            {
                return 1;
            }
        }
        catch(RecordStoreException _ex)
        {
            return 2;
        }
        try
        {
            abyte0 = q(false);
        }
        catch(OutOfMemoryError _ex)
        {
            return 3;
        }
        try
        {
            bk.setRecord(3, abyte0, 0, abyte0.length);
        }
        catch(InvalidRecordIDException _ex)
        {
            try
            {
                bk.addRecord(abyte0, 0, abyte0.length);
            }
            catch(RecordStoreException _ex2)
            {
                return 1;
            }
        }
        catch(RecordStoreException _ex)
        {
            return 2;
        }
        return 0;
    }

    private byte[] ec()
    {
        byte abyte0[];
        (abyte0 = new byte[64])[0] = 18;
        abyte0[1] = 3;
        abyte0[2] = 0;
        abyte0[3] = 0;
        abyte0[4] = 0;
        abyte0[5] = 0;
        abyte0[6] = 0;
        abyte0[7] = 0;
        abyte0[8] = (byte)cv;
        abyte0[9] = (byte)cE;
        abyte0[10] = (byte)cF;
        abyte0[11] = (byte)cG;
        abyte0[12] = (byte)cH;
        abyte0[13] = A;
        abyte0[14] = (byte)(cR | cS << 1 | cT << 2 | cU << 3);
        abyte0[15] = (byte)(h | i << 1 | j << 2);
        abyte0[16] = (byte)cJ;
        abyte0[17] = (byte)cK;
        abyte0[18] = (byte)cL;
        abyte0[19] = (byte)k;
        long l1 = dY.getTime();
        int i1 = 20;
        this = abyte0;
        for(int j1 = 0; j1 < 8; j1++)
        {
            int k1;
            if((k1 = (int)(l1 & 255L)) > 128)
                k1 -= 256;
            this[i1++] = (byte)k1;
            l1 >>= 8;
        }

        abyte0[28] = (byte)cW;
        abyte0[29] = (byte)cY;
        abyte0[30] = (byte)cN;
        abyte0[31] = (byte)cO;
        abyte0[32] = (byte)cP;
        abyte0[33] = cX;
        abyte0[34] = cI;
        abyte0[35] = cM;
        abyte0[36] = cQ;
        abyte0[37] = (byte)(df | dg << 1);
        abyte0[38] = 0;
        abyte0[39] = 0;
        abyte0[40] = cV;
        abyte0[41] = da;
        abyte0[42] = cZ;
        abyte0[43] = l;
        abyte0[44] = (byte)dd;
        abyte0[45] = cC;
        a(abyte0, 46, cD);
        a(abyte0, 48, db);
        a(abyte0, 50, cz);
        a(abyte0, 52, cA);
        a(abyte0, 54, cB);
        a(abyte0, 58, dV);
        a(abyte0, 60, 0);
        a(abyte0, 62, dW);
        return abyte0;
    }

    private byte[] ed()
    {
        int i1 = (cc.e + 7) / 8;
        int j1 = 0;
        for(int l1 = 0; l1 < cc.e; l1++)
        {
            int i2 = a(dB[l1 << 1]) | a(dB[(l1 << 1) + 1]) << 8;
            byte byte0;
            if((byte0 = dC[i2]) != 0 && byte0 != 5)
                j1++;
        }

        byte abyte0[] = new byte[i1 + (j1 << 2)];
        int j2 = 0;
        int k2 = 0;
        i1 = i1;
        for(int k1 = 0; k1 < cc.e; k1++)
        {
            int l2 = a(dB[k1 << 1]) | a(dB[(k1 << 1) + 1]) << 8;
            if((l2 = dC[l2]) != 0)
                if(l2 == 5)
                {
                    abyte0[j2] |= (byte)(1 << k2);
                } else
                {
                    a(abyte0, i1, k1);
                    abyte0[i1 + 2] = (byte)l2;
                    abyte0[i1 + 3] = 0;
                    i1 += 4;
                }
            if(++k2 > 7)
            {
                k2 = 0;
                j2++;
            }
        }

        return abyte0;
    }

    private void ee()
    {
        if(bk != null)
        {
            try
            {
                byte abyte0[] = bk.getRecord(1);
                a(abyte0);
                return;
            }
            catch(RecordStoreException _ex)
            {
                cv = 1;
            }
            t();
            cz = 100;
            cE = 0;
            h = 0;
            i = 0;
            j = 0;
            A = 1;
            cR = 1;
            cS = 1;
            cT = 0;
            cU = 1;
            cV = 1;
            k = 100;
            l = 100;
            cZ = 0;
            cW = 1;
            cX = 0;
            cY = 0;
            dc = 0;
            dZ = new Date(dY.getTime());
            dF = 0;
            for(int i1 = 0; i1 < 6; i1++)
                dD[i1] = 0;

            db = 0;
            dd = 0;
            al(dd);
            dV = 0;
            aU = true;
            return;
        } else
        {
            c("NULL!!");
            return;
        }
    }

    private void a(byte abyte0[])
    {
        if(abyte0.length >= 64)
        {
            ct = abyte0[0];
            cu = abyte0[1];
            cv = abyte0[8];
            t();
            cE = abyte0[9];
            cF = abyte0[10];
            cG = abyte0[11];
            cH = abyte0[12];
            A = abyte0[13];
            cR = (byte)(abyte0[14] & 1);
            cS = (byte)(abyte0[14] >> 1 & 1);
            cT = (byte)(abyte0[14] >> 2 & 1);
            cU = (byte)(abyte0[14] >> 3 & 1);
            if(ct < 7)
            {
                h = 0;
                i = 0;
                j = 0;
                l = 100;
            } else
            {
                h = (byte)(abyte0[15] & 1);
                i = (byte)(abyte0[15] >> 1 & 1);
                j = (byte)(abyte0[15] >> 2 & 1);
                l = abyte0[43];
            }
            if(ct < 10)
            {
                cN = 0;
                cO = 2;
                cP = 0;
                cV = 1;
                cZ = 1;
            } else
            {
                cN = abyte0[30];
                cO = abyte0[31];
                cP = abyte0[32];
                cV = abyte0[40];
                cZ = abyte0[42];
            }
            cJ = abyte0[16];
            cK = abyte0[17];
            cL = abyte0[18];
            if(ct < 4)
                k = 100;
            else
                k = abyte0[19];
            if(ct < 16)
            {
                cI = 0;
                cM = 0;
                cQ = 0;
            } else
            {
                cI = abyte0[34];
                cM = abyte0[35];
                cQ = abyte0[36];
            }
            if(ct < 17)
            {
                df = 1;
                dg = 0;
            } else
            {
                df = (byte)(abyte0[37] & 1);
                dg = (byte)(abyte0[37] >> 1 & 1);
            }
            if(ct < 18)
            {
                cC = 0;
                cD = 0;
                da = 1;
            } else
            {
                cC = abyte0[45];
                cD = e(abyte0, 46);
                da = abyte0[41];
            }
            long l1 = 20;
            byte abyte1[] = abyte0;
            long l2 = 0L;
            for(int i1 = 7; i1 >= 0; i1--)
            {
                int j1;
                if((j1 = abyte1[i1 + 20]) < 0)
                    j1 += 256;
                l2 = l2 << 8 | (long)j1;
            }

            abyte1 = l2;
            dZ = new Date(abyte1);
            cW = abyte0[28];
            cY = abyte0[29];
            cX = abyte0[33];
            dd = abyte0[44];
            al(dd);
            dc = 0;
            db = e(abyte0, 48);
            cz = e(abyte0, 50);
            cA = e(abyte0, 52);
            cB = e(abyte0, 54);
            dV = e(abyte0, 58);
            dW = e(abyte0, 62);
        }
    }

    private void a(int i1, byte abyte0[])
    {
        if(i1 == 0)
        {
            for(int j1 = 0; j1 < abyte0.length; j1++)
                dC[j1] = abyte0[j1];

        } else
        if(i1 >= 1)
        {
            int k1 = 16493;
            if(i1 == 2 || i1 == 3)
                k1 = cc.e;
            i1 = (k1 + 7) / 8;
            int i2 = 0;
            for(int k2 = 0; k2 < i1; k2++)
            {
                int j3;
                if((j3 = a(abyte0[k2])) != 0)
                {
                    int l1 = 1;
                    for(int i4 = 0; i4 < 8; i4++)
                    {
                        if((j3 & l1) != 0)
                            dC[i2 + i4] = 5;
                        l1 <<= 1;
                    }

                }
                i2 += 8;
            }

            for(int l2 = i1; l2 < abyte0.length; l2 += 4)
            {
                int k3 = e(abyte0, l2);
                dC[k3] = abyte0[l2 + 2];
            }

        }
        byte abyte1[] = new byte[cc.e];
        i1 = 0;
        for(int j2 = 0; j2 < cc.e; j2++)
        {
            int i3;
            if((i3 = dB[i1++]) < 0)
                i3 += 256;
            int l3;
            if((l3 = dB[i1++]) < 0)
                l3 += 256;
            abyte1[i3 | l3 << 8] = dC[j2];
        }

        dC = null;
        dC = abyte1;
    }

    private static void a(ByteArrayOutputStream bytearrayoutputstream, String s1)
    {
        int i1 = s1.length();
        a(bytearrayoutputstream, i1 << 1);
        for(int j1 = 0; j1 < i1; j1++)
        {
            char c1 = s1.charAt(j1);
            a(bytearrayoutputstream, c1 ^ 0x7149 ^ j1);
        }

    }

    private byte[] q(boolean flag)
    {
        ByteArrayOutputStream bytearrayoutputstream = new ByteArrayOutputStream();
        try
        {
            a(bytearrayoutputstream, 21);
            b(bytearrayoutputstream, aR);
            a(bytearrayoutputstream, 31);
            a(bytearrayoutputstream, bL);
            a(bytearrayoutputstream, 32);
            b(bytearrayoutputstream, dc);
            for(int i1 = 0; i1 < eg.size(); i1++)
            {
                ai ai1 = (ai)eg.elementAt(i1);
                a(bytearrayoutputstream, 33);
                b(bytearrayoutputstream, ai1.a);
                b(bytearrayoutputstream, ai1.b);
            }

            a(bytearrayoutputstream, 41);
            a(bytearrayoutputstream, n);
            a(bytearrayoutputstream, aK);
            a(bytearrayoutputstream, aL);
            a(bytearrayoutputstream, 44);
            a(bytearrayoutputstream, aM);
            a(bytearrayoutputstream, 51);
            a(bytearrayoutputstream, bO);
            for(int j1 = 0; j1 < em.size(); j1++)
            {
                ag ag1 = (ag)em.elementAt(j1);
                a(bytearrayoutputstream, 54);
                b(bytearrayoutputstream, ag1.a);
                b(bytearrayoutputstream, ag1.b);
                byte byte0 = ag1.c;
                ByteArrayOutputStream bytearrayoutputstream1 = bytearrayoutputstream;
                byte abyte1[] = new byte[1];
                int i3 = byte0;
                if(byte0 > 128)
                    i3 -= 256;
                abyte1[0] = (byte)i3;
                bytearrayoutputstream1.write(abyte1, 0, 1);
                b(bytearrayoutputstream, ag1.d);
            }

            if(flag)
            {
                String s1 = "J2ME";
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 0);
                a(bytearrayoutputstream, s1);
                s1 = System.getProperty("microedition.platform");
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 1);
                a(bytearrayoutputstream, s1);
                s1 = "" + g.a;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 3);
                a(bytearrayoutputstream, s1);
                s1 = aM;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 5);
                a(bytearrayoutputstream, s1);
                s1 = dj + " " + dk;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 10);
                a(bytearrayoutputstream, s1);
                if(aH)
                    s1 = "1";
                else
                    s1 = "0";
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 11);
                a(bytearrayoutputstream, s1);
                if(v.hasPointerMotionEvents())
                    s1 = "1";
                else
                    s1 = "0";
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 12);
                a(bytearrayoutputstream, s1);
                s1 = g.c;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 13);
                a(bytearrayoutputstream, s1);
                s1 = System.getProperty("microedition.media.version");
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 14);
                a(bytearrayoutputstream, s1);
                s1 = "";
                for(flag = false; flag < fd.length; flag++)
                {
                    String s2;
                    String as1[] = Manager.getSupportedProtocols(s2 = fd[flag]);
                    s1 = s1 + s2 + ":";
                    for(int j2 = 0; j2 < as1.length; j2++)
                        s1 = s1 + " " + as1[j2];

                    s1 = s1 + "\n";
                }

                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 15);
                a(bytearrayoutputstream, s1);
                if(m)
                    s1 = "1";
                else
                    s1 = "0";
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 20);
                a(bytearrayoutputstream, s1);
                s1 = System.getProperty("microedition.encoding");
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 21);
                a(bytearrayoutputstream, s1);
                s1 = "" + Runtime.getRuntime().totalMemory();
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 31);
                a(bytearrayoutputstream, s1);
                s1 = "" + Runtime.getRuntime().freeMemory();
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 32);
                a(bytearrayoutputstream, s1);
                flag = false;
                try
                {
                    flag = bk.getSize();
                }
                catch(Exception _ex) { }
                s1 = "" + flag;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 33);
                a(bytearrayoutputstream, s1);
                int k2 = 0;
                try
                {
                    k2 = bk.getSizeAvailable();
                }
                catch(Exception _ex) { }
                s1 = "" + k2;
                a(bytearrayoutputstream, 61);
                a(bytearrayoutputstream, 34);
                a(bytearrayoutputstream, s1);
            }
            for(int k1 = 0; k1 < dQ; k1++)
            {
                a(bytearrayoutputstream, 91);
                b(bytearrayoutputstream, (String)dR.elementAt(k1));
            }

            a(bytearrayoutputstream, 101);
            a(bytearrayoutputstream, 14);
            for(int l1 = 0; l1 < 14; l1++)
                b(bytearrayoutputstream, t[l1]);

            a(bytearrayoutputstream, 201);
            a(bytearrayoutputstream, ec.size());
            a(bytearrayoutputstream, ed);
            for(int i2 = 0; i2 < ec.size(); i2++)
            {
                w w1 = (w)ec.elementAt(i2);
                b(bytearrayoutputstream, w1.a);
                a(bytearrayoutputstream, w1.b);
                a(bytearrayoutputstream, w1.d);
                if(w1.b > 0)
                {
                    flag = w1.c;
                    for(int l2 = 0; l2 < w1.b; l2++)
                        b(bytearrayoutputstream, (String)flag.elementAt(l2));

                }
            }

        }
        catch(Exception exception)
        {
            a("sv", exception);
        }
        byte abyte0[];
        return abyte0 = bytearrayoutputstream.toByteArray();
    }

    private static int a(byte abyte0[], boolean flag)
    {
        Object obj;
        int j1;
        int k1;
        Vector vector;
        String s3;
        int l1;
        int j2;
        obj = new ByteArrayInputStream(abyte0);
        new DataInputStream(((InputStream) (obj)));
        obj = "";
        j1 = 0;
        k1 = 0;
        vector = new Vector();
        j2 = 0;
        l1 = b(abyte0, 0);
        j2 += 2;
        if(l1 == 21)
        {
            String s2 = c(abyte0, 2);
            j2 = 2 + (2 + (s2.length() << 1));
            l1 = b(abyte0, j2);
            j2 += 2;
            obj = s2;
        }
        if(l1 == 31)
        {
            j1 = b(abyte0, j2);
            j2 += 2;
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        if(l1 == 32)
        {
            k1 = a(abyte0, j2);
            j2 += 4;
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        while(l1 == 33) 
        {
            l1 = c(abyte0, j2);
            j2 += 2 + (l1.length() << 1);
            String s8 = c(abyte0, j2);
            j2 += 2 + (s8.length() << 1);
            vector.addElement(new ai(l1, s8));
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        if(l1 != 41)
            break MISSING_BLOCK_LABEL_459;
        s3 = d(abyte0, j2);
        j2 += 2 + (s3.length() << 1);
        if(!flag)
            n = s3;
        l1 = d(abyte0, j2);
        j2 += 2 + (l1.length() << 1);
        s3 = d(abyte0, j2);
        j2 += 2 + (s3.length() << 1);
        if(!flag)
        {
            aL = s3;
            aK = l1;
            break MISSING_BLOCK_LABEL_448;
        }
        if(s3.length() + 396 < 411)
            return 2;
        int k2;
        int i3;
        if(s3.compareTo(aL) == 0)
            break MISSING_BLOCK_LABEL_448;
        k2 = Integer.parseInt(aL.substring(5, 10));
        i3 = 0;
        if(l1.length() == 10)
            i3 = Integer.parseInt(l1.substring(0, 5)) + Integer.parseInt(l1.substring(5, 10));
        else
            i3 = Integer.parseInt(l1.substring(2, 7)) + Integer.parseInt(l1.substring(7, 12));
        if((k2 ^ 0x5b6e) != (i3 & 0xffff))
            return 2;
        l1 = b(abyte0, j2);
        j2 += 2;
        aR = ((String) (obj));
        bL = j1;
        dc = k1;
        eg = vector;
        if(l1 == 44)
        {
            String s4 = d(abyte0, j2);
            j2 += 2 + (s4.length() << 1);
            if(!flag)
                aM = s4;
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        if(l1 == 51)
        {
            bO = b(abyte0, j2);
            j2 += 2;
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        while(l1 == 53) 
        {
            l1 = c(abyte0, j2);
            j2 += 2 + (l1.length() << 1);
            String s9 = c(abyte0, j2);
            j2 += 2 + (s9.length() << 1);
            String s12 = c(abyte0, j2);
            j2 += 2 + (s12.length() << 1);
            flag = c(abyte0, j2);
            j2 += 2 + (flag.length() << 1);
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        while(l1 == 54) 
        {
            l1 = c(abyte0, j2);
            j2 += 2 + (l1.length() << 1);
            String s10 = c(abyte0, j2);
            j2 += 2 + (s10.length() << 1);
            byte byte0 = abyte0[j2];
            j2++;
            flag = c(abyte0, j2);
            j2 += 2 + (flag.length() << 1);
            ag ag1;
            (ag1 = new ag(l1, s10)).c = byte0;
            String s1 = flag;
            flag = ag1;
            ag1.d = s1;
            em.addElement(ag1);
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        while(l1 == 61) 
        {
            j2 += 2;
            String s11 = c(abyte0, j2);
            j2 += 2 + (s11.length() << 1);
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        while(l1 == 91) 
        {
            String s5 = c(abyte0, j2);
            j2 += 2 + (s5.length() << 1);
            dR.addElement(s5);
            l1 = b(abyte0, j2);
            j2 += 2;
        }
        dQ = dR.size();
        if(l1 == 101)
        {
            j2 += 2;
            for(l1 = 0; l1 < 14; l1++)
            {
                t[l1] = a(abyte0, j2);
                j2 += 4;
            }

            l1 = b(abyte0, j2);
            j2 += 2;
        }
        if(l1 == 201)
        {
            int i2 = b(abyte0, j2);
            j2 += 2;
            ed = b(abyte0, j2);
            j2 += 2;
            for(int l2 = 0; l2 < i2; l2++)
            {
                w w1 = new w();
                String s6 = c(abyte0, j2);
                j2 += 2 + (s6.length() << 1);
                w1.a = s6;
                w1.b = b(abyte0, j2);
                j2 += 2;
                w1.d = b(abyte0, j2);
                j2 += 2;
                flag = new Vector();
                if(w1.b > 0)
                {
                    for(int i1 = 0; i1 < w1.b; i1++)
                    {
                        String s7 = c(abyte0, j2);
                        j2 += 2 + (s7.length() << 1);
                        flag.addElement(s7);
                    }

                }
                w1.c = flag;
                ec.addElement(w1);
            }

        }
        break MISSING_BLOCK_LABEL_1149;
        Exception exception;
        exception;
        a("lv", exception);
        return 1;
        return -1;
    }

    final void m()
    {
        if(bk != null)
        {
            try
            {
                bk.closeRecordStore();
                bk = null;
                return;
            }
            catch(RecordStoreException _ex)
            {
                this = "不能关闭数据库";
            }
            bi.setString(this);
            cb.setCurrent(bi);
        }
    }

    private static void a(OutputStream outputstream, int i1)
    {
        try
        {
            outputstream.write(i1 & 0xff);
            outputstream.write(i1 >> 8 & 0xff);
            outputstream.write(i1 >> 16 & 0xff);
            outputstream.write(i1 >>> 24);
            return;
        }
        // Misplaced declaration of an exception variable
        catch(OutputStream outputstream)
        {
            a("wi", ((Exception) (outputstream)));
        }
    }

    public final void n()
    {
        FileConnection fileconnection = null;
        Object obj = Calendar.getInstance();
        Date date = new Date();
        boolean flag = true;
        ((Calendar) (obj)).setTime(date);
        obj = "record(" + ((Calendar) (obj)).get(1) + "." + (((Calendar) (obj)).get(2) + 1) + "." + ((Calendar) (obj)).get(5) + ").dat";
        try
        {
            String s1 = aR + obj;
            Object obj1 = null;
            Object obj2 = null;
            XConnection xconnection = new XConnection();
            if(s1.startsWith("sms"))
                obj2 = xconnection;
            else
                obj2 = Connector.open(s1);
            if(!(fileconnection = (FileConnection)obj2).exists())
                fileconnection.create();
            OutputStream outputstream;
            (outputstream = fileconnection.openOutputStream()).write(77);
            outputstream.write(68);
            outputstream.write(82);
            outputstream.write(48);
            byte abyte0[] = ec();
            a(outputstream, abyte0.length);
            outputstream.write(abyte0, 0, abyte0.length);
            abyte0 = ed();
            a(outputstream, abyte0.length);
            outputstream.write(abyte0, 0, abyte0.length);
            abyte0 = q(true);
            a(outputstream, abyte0.length);
            outputstream.write(abyte0, 0, abyte0.length);
            outputstream.close();
        }
        catch(Exception exception)
        {
            d("备份数据失败!\n" + aR + obj + "\n" + exception.toString());
            a("wr", exception);
            flag = false;
        }
        try
        {
            if(fileconnection != null)
                fileconnection.close();
        }
        catch(Exception exception1)
        {
            a("wrc", exception1);
        }
        if(flag)
            d("备份数据成功!\n" + obj);
    }

    public final int a(String s1)
    {
        FileConnection fileconnection;
        byte byte0;
        fileconnection = null;
        Object obj = null;
        byte0 = 0;
        Object obj2;
        String s2 = s1;
        Object obj1 = null;
        obj2 = null;
        XConnection xconnection = new XConnection();
        if(s2.startsWith("sms"))
            obj2 = xconnection;
        else
            obj2 = Connector.open(s2);
        if(!(fileconnection = (FileConnection)obj2).exists())
            return 2;
        try
        {
            fileconnection.fileSize();
            s1 = 0;
            InputStream inputstream = fileconnection.openInputStream();
            s1 = 0;
            s1 = 0;
            s1 = 0;
            s1 = 0;
            if((s1 = inputstream.read()) != 77)
                byte0 = 1;
            if(byte0 == 0 && (s1 = inputstream.read()) != 68)
                byte0 = 1;
            if(byte0 == 0 && (s1 = inputstream.read()) != 82)
                byte0 = 1;
            if(byte0 == 0 && (s1 = inputstream.read()) == -1)
                byte0 = 1;
            if(byte0 == 0)
            {
                byte abyte0[] = new byte[s1 = a(inputstream)];
                inputstream.read(abyte0, 0, s1);
                byte byte1;
                if((byte1 = abyte0[1]) != 3)
                {
                    byte0 = 3;
                } else
                {
                    byte abyte1[] = new byte[s1 = a(inputstream)];
                    inputstream.read(abyte1, 0, s1);
                    byte abyte2[] = new byte[s1 = a(inputstream)];
                    inputstream.read(abyte2, 0, s1);
                    ec = null;
                    ec = new Vector();
                    if((s1 = a(abyte2, true)) == 1)
                        byte0 = 5;
                    else
                    if(s1 == 2)
                    {
                        byte0 = 4;
                    } else
                    {
                        a(abyte0);
                        dC = null;
                        dC = new byte[cc.e];
                        if(byte1 >= 3)
                        {
                            if(cd.b == 'D')
                                cd.a();
                            cd = cc;
                        }
                        a(cu, abyte1);
                    }
                }
            }
            inputstream.close();
        }
        // Misplaced declaration of an exception variable
        catch(String s1)
        {
            a("rr", ((Exception) (s1)));
            byte0 = 5;
        }
        try
        {
            if(fileconnection != null)
                fileconnection.close();
        }
        // Misplaced declaration of an exception variable
        catch(String s1)
        {
            a("rrc", ((Exception) (s1)));
        }
        if(byte0 == 0)
        {
            o();
            cy = p();
            if(cB >= dG)
                cB = 0;
            db = cy[cB];
            eg();
        }
        return byte0;
    }

    public static void b(int i1)
    {
        FileConnection fileconnection = null;
        Vector vector = ((w) (i1 = (w)ec.elementAt(i1))).c;
        try
        {
            String s2 = aR + ((w) (i1)).a + ".txt";
            Object obj = null;
            Object obj1 = null;
            XConnection xconnection = new XConnection();
            if(s2.startsWith("sms"))
                obj1 = xconnection;
            else
                obj1 = Connector.open(s2);
            if(!(fileconnection = (FileConnection)obj1).exists())
                fileconnection.create();
            i1 = fileconnection.openOutputStream();
            (i1 = new ak(i1, 1024)).a(255);
            i1.a(254);
            for(int j1 = 0; j1 < vector.size(); j1++)
            {
                String s1 = (String)vector.elementAt(j1);
                for(int k1 = 0; k1 < s1.length(); k1++)
                {
                    char c1 = s1.charAt(k1);
                    i1.a(c1 & 0xff);
                    i1.a(c1 >> 8 & 0xff);
                }

                i1.a(13);
                i1.a(0);
                i1.a(10);
                i1.a(0);
            }

            i1.a();
        }
        // Misplaced declaration of an exception variable
        catch(int i1)
        {
            a("wn", i1);
        }
        try
        {
            if(fileconnection != null)
                fileconnection.close();
            return;
        }
        // Misplaced declaration of an exception variable
        catch(int i1)
        {
            a("wnc", i1);
        }
    }

    public final void a(String s1, String s2)
    {
        this = null;
        String s3 = s1 + s2;
        Object obj = null;
        Object obj1 = null;
        XConnection xconnection = new XConnection();
        if(s3.startsWith("sms"))
            obj1 = xconnection;
        else
            obj1 = Connector.open(s3);
        if(!exists())
        {
            if(this != null)
                close();
            a("提示", "文件不存在!", 0);
            return;
        }
        try
        {
            s1 = openInputStream();
            s1 = new h(s1, 1024);
            boolean flag = false;
            if(s2.toLowerCase().endsWith(".txt"))
                s2 = s2.substring(0, s2.length() - 4);
            else
                s2 = s2;
            int i1 = 0;
            do
            {
                if(i1 >= ec.size())
                    break;
                w w2 = (w)ec.elementAt(i1);
                if(s2.compareTo(w2.a) == 0)
                {
                    ed = i1;
                    flag = true;
                    break;
                }
                i1++;
            } while(true);
            if(!flag)
                x(s2);
            w w1 = (w)ec.elementAt(ed);
            Vector vector = new Vector();
            do
            {
                if((s2 = s1.b()) == null)
                    break;
                if((s2 = s2.trim()).length() > 0)
                    vector.addElement(s2);
            } while(true);
            s1.a();
            w1.c = null;
            w1.c = vector;
            w1.b = vector.size();
            w1.d = 0;
            if(this != null)
                close();
            return;
        }
        // Misplaced declaration of an exception variable
        catch(String s1)
        {
            a("rn", ((Exception) (s1)));
        }
        return;
    }

    final void o()
    {
        if(cv == 0)
        {
            cv = 1;
            t();
        }
        if(cz == 0)
            cz = 100;
        for(int i1 = 0; i1 < 6; i1++)
            dD[i1] = 0;

        dF = 0;
        for(int j1 = 0; j1 < dC.length; j1++)
        {
            byte byte0 = cc.d.s[j1];
            if((cw & byte0) != cx)
                continue;
            switch(dC[j1] & 7)
            {
            case 1: // '\001'
                dD[1]++;
                dF += 2;
                break;

            case 2: // '\002'
                dD[2]++;
                dF += 4;
                break;

            case 3: // '\003'
                dD[3]++;
                dF += 6;
                break;

            case 4: // '\004'
                dD[4]++;
                dF += 8;
                break;

            case 5: // '\005'
                dD[5]++;
                dF += 10;
                break;

            default:
                dD[0]++;
                break;
            }
        }

        dG = 0;
        for(int k1 = 0; k1 < 6; k1++)
            dG += dD[k1];

        cA = ((dG + cz) - 1) / cz;
    }

    private static void ef()
    {
        for(int i1 = 0; i1 < 6; i1++)
            dE[i1] = 0;

        for(int j1 = 0; j1 < dC.length; j1++)
            switch(dC[j1] & 7)
            {
            case 1: // '\001'
                dE[1]++;
                break;

            case 2: // '\002'
                dE[2]++;
                break;

            case 3: // '\003'
                dE[3]++;
                break;

            case 4: // '\004'
                dE[4]++;
                break;

            case 5: // '\005'
                dE[5]++;
                break;

            default:
                dE[0]++;
                break;
            }

    }

    final void c(int i1)
    {
        cB = i1 = (i1 - 1) * cz;
        db = cy[i1];
        int j1 = db;
        i1 = cc;
        cc.r = j1;
        cc.a(db);
    }

    final short[] p()
    {
        short aword0[] = new short[dG];
        int i1 = 0;
        int j1 = cc.e;
        for(int k1 = 0; k1 < j1; k1++)
        {
            byte byte0 = cc.d.s[k1];
            if((cw & byte0) != cx)
                continue;
            if(cC == 1)
            {
                aword0[dG - i1 - 1] = (short)k1;
                i1++;
            } else
            {
                aword0[i1++] = (short)k1;
            }
        }

        if(cC == 2)
        {
            Random random = new Random(cD);
            for(int l1 = 0; l1 < dG; l1++)
            {
                this = Math.abs(random.nextInt() % dG);
                short word0 = aword0[l1];
                aword0[l1] = aword0[this];
                aword0[this] = word0;
            }

        }
        return aword0;
    }

    private void eg()
    {
        Calendar calendar;
        (calendar = Calendar.getInstance()).setTime(dY);
        calendar.get(1);
        calendar.get(2);
        calendar.get(5);
        (calendar = Calendar.getInstance()).setTime(dZ);
        calendar.get(1);
        calendar.get(2);
        calendar.get(5);
        long l2 = dY.getTime() / 0x5265c00L;
        long l3 = dZ.getTime() / 0x5265c00L;
        if((this = (int)(l2 - l3)) <= 0)
            return;
        if(this > 1)
        {
            for(int i1 = 14; i1 >= 1; i1--)
            {
                if(dX[i1] == 0)
                    continue;
                int k1;
                if((k1 = i1 + this) > 15)
                    k1 = 16;
                for(int i2 = i1 + 1; i2 < k1; i2++)
                    dX[i2]++;

            }

        }
        for(int j1 = 0; j1 < dC.length; j1++)
        {
            int l1;
            if((l1 = dC[j1] & 7) == 0 && l1 >= 5)
                continue;
            int j2;
            if((j2 = dC[j1] >> 3 & 0xf) != 0 && j2 != 15)
                if(j2 + this < 15)
                    j2 += this;
                else
                    j2 = 15;
            dC[j1] &= 0x87;
            dC[j1] |= j2 << 3;
            if(dC[j1] > 0 && dX[j2] != 0)
            {
                dC[j1] |= 0x80;
                dV++;
            }
        }

    }

    final void q()
    {
        int i1 = -1;
        dV = 0;
        for(int j1 = 0; j1 < dC.length; j1++)
        {
            int l1 = dC[j1] >> 3 & 0xf;
            int i2 = dC[j1] & 7;
            if(dS[l1] || dT[i2])
            {
                if(dC[j1] > 0)
                    dC[j1] |= 0x80;
                dV++;
                if(i1 < 0)
                    i1 = j1;
                continue;
            }
            if(dC[j1] < 0)
                dC[j1] &= 0x7f;
        }

        if(i1 >= 0)
        {
            dW = i1;
            int k1 = dW;
            s s1 = cc;
            cc.r = k1;
            cc.a(dW);
            v.f();
            v.e();
        }
    }

    final void r()
    {
        av = true;
        ck = new Timer();
        cl = new j(this, 3, 0);
        ck.schedule(cl, 500L, 500L);
        aw = true;
    }

    final void s()
    {
        av = false;
        if(ck != null)
        {
            ck.cancel();
            ck = null;
        }
        if(cl != null)
        {
            cl.cancel();
            cl = null;
        }
        aw = false;
    }

    private static String d(byte abyte0[], int i1)
    {
        int j1;
        if((j1 = b(abyte0, i1)) == 0)
            return "";
        char ac1[] = new char[j1 >> 1];
        i1 += 2;
        for(int k1 = 0; k1 < j1 - 1; k1 += 2)
        {
            int l1;
            l1 = (char)((l1 = a(abyte0[i1 + k1]) + (a(abyte0[i1 + k1 + 1]) << 8)) ^ 0x7149 ^ k1 >> 1);
            ac1[k1 >> 1] = l1;
        }

        return abyte0 = new String(ac1, 0, j1 >> 1);
    }

    final String d(int i1)
    {
        for(int j1 = 0; j1 < aO.length; j1++)
            if(i1 == aO[j1])
                return aN[j1];

        return "";
    }

    final int e(int i1)
    {
        for(int j1 = 0; j1 < aO.length; j1++)
            if(i1 == aO[j1])
                return j1;

        return 0;
    }

    static void t()
    {
        switch(cv)
        {
        case 1: // '\001'
            cw = 129;
            cx = 1;
            return;

        case 2: // '\002'
            cw = 130;
            cx = 2;
            return;

        case 3: // '\003'
            cw = 132;
            cx = 4;
            return;

        case 4: // '\004'
            cw = 136;
            cx = 8;
            return;

        case 5: // '\005'
            cw = 144;
            cx = 16;
            return;

        case 6: // '\006'
            cw = 160;
            cx = 32;
            return;

        case 7: // '\007'
            cw = 192;
            cx = 64;
            return;

        case 101: // 'e'
            cw = 129;
            cx = 129;
            return;

        case 102: // 'f'
            cw = 130;
            cx = 130;
            return;

        case 103: // 'g'
            cw = 132;
            cx = 132;
            return;
        }
        cw = 0;
        cx = 1;
    }

    final void f(int i1)
    {
        bV = null;
        switch(i1)
        {
        case 1: // '\001'
            (bV = new o("软件帮助", dl, dw, dx, dy, dz, dn, dd, 0)).a("软件功能", 8192);
            bV.a("记忆宝手机背单词,随时随地学英语!");
            bV.a("");
            bV.a("* 真人英中双语朗读,闭着眼睛飘单词");
            bV.a("* 例句巧记同义反义,全方位立体记忆");
            bV.a("* 艾宾浩斯遗忘曲线,科学高效记单词");
            bV.a("* 单词熟悉程度管理,我的单词我掌握");
            bV.a("* 海量词典+屏幕取词,单词越学越过瘾");
            bV.a("* 教材+书籍+MP3,听读同步随身学");
            bV.a("");
            bV.a("按键说明", 8192);
            bV.a("1键 -- 单词降级");
            bV.a("3键 -- 单词升级");
            bV.a("*键 -- 朗读");
            bV.a("0键 -- 加入单词本");
            bV.a("#键 -- 屏幕取词");
            bV.a("左软键/7 -- 菜单(或取消)");
            bV.a("右软键/9 -- 返回(或确认)");
            bV.a("确认键/5 -- 确定当前选择");
            bV.a("上键/2 -- 向上移动");
            bV.a("下键/8 -- 向下移动");
            bV.a("左键/4 -- 向上翻页");
            bV.a("右键/6 -- 向下翻页");
            bV.a("");
            bV.a("更多信息请访问记忆宝网络", 8192);
            bV.a("http://www.jiyibao.com", 8192);
            break;

        case 2: // '\002'
            bV = new o("系统信息", dl, dw, dx, dy, dz, dn, dd, 0);
            System.gc();
            if(aC)
                bV.a("支持文件访问(" + g.c + ")");
            else
                bV.a("不支持文件访问");
            String s1;
            i1 = Manager.getSupportedProtocols(s1 = "audio/amr");
            s1 = s1 + ":";
            for(int j1 = 0; j1 < i1.length; j1++)
                s1 = s1 + " " + i1[j1];

            if(aE)
                bV.a("支持标准语音(" + s1 + ")");
            else
                bV.a("不支持标准语音");
            i1 = Manager.getSupportedProtocols(s1 = aS);
            s1 = s1 + ":";
            for(int k1 = 0; k1 < i1.length; k1++)
                s1 = s1 + " " + i1[k1];

            if(aD)
                bV.a("支持高音质语音(" + s1 + ")");
            else
                bV.a("不支持高音质语音");
            bV.a("可用内存: " + Runtime.getRuntime().totalMemory() + "字节");
            bV.a("剩余内存: " + Runtime.getRuntime().freeMemory() + "字节");
            try
            {
                int l1 = bk.getSizeAvailable();
                bV.a("剩余记录: " + l1 + "字节");
            }
            // Misplaced declaration of an exception variable
            catch(MemoDictMIDlet this)
            {
                bV.a("剩余记录: " + toString());
            }
            break;

        case 3: // '\003'
            (bV = new o("软件注册", dl, dw, dx, dy, dz, dn, dd, 0)).a("用户名");
            if(aJ)
                bV.a(n);
            else
                bV.e(n);
            bV.a("验证码");
            bV.a(aK);
            bV.a("注册码");
            if(aJ)
                bV.a("已注册, 瓜瓜破解分享!");
            else
                bV.e(aL);
            if(!aJ)
            {
                bV.a("");
                bV.a("获取注册码请访问记忆宝网络, 感谢您的支持!");
            }
            bV.h(1);
            bV.i = 101;
            break;

        default:
            (bV = new o("关于", dl, dw, dx, dy, dz, dn, dd, 0)).a(dA, 8192);
            this = "版本: 1.9.5";
            bV.a(this, 8192);
            bV.a("版权所有(C)2010", 8192);
            bV.a("记忆宝网络", 8192);
            bV.a("http://www.jiyibao.com", 8192);
            break;
        }
        bV.a(aV, aX);
    }

    final void g(int i1)
    {
        if(bT != null)
            u();
        bT = null;
        switch(i1)
        {
        case 1: // '\001'
            (bT = new o("设置", dl, dw, dx, dy, dz, dn, dd, 0, 11)).a("屏幕配色方案");
            bp = bT.d();
            bT.d("默认");
            bT.d("护眼");
            bT.d("夜间");
            bT.d("自定义");
            bT.b(bp + dd);
            if(dd == 3)
            {
                bJ = bT.d();
                i1 = 0;
                for(int j1 = 0; j1 < aP.length; j1++)
                {
                    int l1;
                    if((l1 = dm.stringWidth(aP[j1])) > i1)
                        i1 = l1;
                }

                i1 += 2;
                bT.b(aP[0], i1, t[0]);
                bT.b(aP[1], i1, t[1]);
                bT.b(aP[2], i1, t[5]);
                bT.b(aP[3], i1, t[6]);
                bT.b(aP[4], i1, t[7]);
                bT.b(aP[5], i1, t[9]);
                bT.b(aP[6], i1, t[10]);
                bT.b(aP[7], i1, t[11]);
                bT.b(aP[8], i1, t[12]);
                bT.b(aP[9], i1, t[13]);
            }
            this = Font.getFont(0, 0, 16).getHeight();
            i1 = Font.getFont(0, 0, 0).getHeight();
            int k1 = Font.getFont(0, 0, 8).getHeight();
            if(this != i1 || i1 != k1)
            {
                bT.a("显示文字大小");
                bo = bT.d();
                bT.d("大字体");
                bT.d("中字体");
                bT.d("小字体");
                bT.b(bo + cE);
            } else
            {
                bo = -1;
            }
            bT.a("屏幕设置");
            bq = bT.d();
            bT.c("开启全屏");
            bT.a(bq, h != 0);
            bT.c("开启横屏");
            bT.a(bq + 1, i != 0);
            if(i != 0)
            {
                bs = bT.d();
                bT.d("左横屏");
                bT.d("右横屏");
                bT.b(bs + j);
            }
            br = bT.d();
            bT.c("确认、取消位置互换");
            bT.a(br, cZ != 0);
            if(g.d)
            {
                bT.c("开启背光常亮");
                bT.a(br + 1, cY != 0);
            }
            if(g.e)
            {
                bT.a("屏幕亮度(0-100)");
                aA = bT.d();
                bT.e(Integer.toString(l));
            }
            bT.h(1);
            break;

        case 2: // '\002'
            (bT = new o("设置", dl, dw, dx, dy, dz, dn, dd, 0, 12)).a("键盘设置");
            break;

        case 3: // '\003'
            bT = new o("设置", dl, dw, dx, dy, dz, dn, dd, 0, 13);
            if(aG)
            {
                bT.a("语音设置");
                bT.c("开启声音");
                bT.a(1, A != 0);
                bT.a("音量大小(0-100)");
                az = bT.d();
                bT.e(Integer.toString(k));
                bT.a("自动朗读内容");
                bt = bT.d();
                bT.c("自动朗读单词");
                bT.a(bt, cR != 0);
                bT.c("自动朗读解释");
                bT.a(bt + 1, cS != 0);
                bT.c("自动拼读");
                bT.a(bt + 2, cT != 0);
                bT.c("开启音效(拼写测试)");
                bT.a(bt + 3, cU != 0);
                bT.a("自动朗读次数");
                bT.e(Integer.toString(cV));
                bT.h(1);
            }
            break;

        case 4: // '\004'
            bT = new o("设置", dl, dw, dx, dy, dz, dn, dd, 0, 14);
            if(aF)
            {
                bT.a("扩展设置");
                bu = bT.d();
                bT.c("显示例句");
                bT.a(bu, cW != 0);
                bT.c("开启情景例句");
                bT.a(bu + 1, cX != 0);
                bT.h(1);
                bT.a("音标设置");
                bv = bT.d();
                bT.c("单词提示时显示音标");
                bT.a(bv, df != 0);
                bT.c("音标使用手机字体");
                bT.a(bv + 1, dg != 0);
            }
            break;

        default:
            bT = new o("设置", dl, dw, dx, dy, dz, dn, dd, 0, 15);
            if(aC)
            {
                bT.a("文件目录:");
                bT.e(aR);
                bT.b("设置文件目录", 1);
                bT.b("备份数据", 2);
                bT.b("恢复数据", 3);
                bT.h(1);
            }
            break;
        }
        bT.z = true;
        bT.a(aV, aX);
    }

    final boolean u()
    {
        boolean flag = false;
        String s3;
        switch(f.i)
        {
        case 11: // '\013'
            int i1;
            if(bo > 0 && (i1 = bT.d(bo)) != cE)
            {
                cE = i1;
                ai(i1);
                flag = true;
            }
            if(dd == 3)
            {
                int ai1[];
                (ai1 = new int[14])[0] = ((y)(y)bT.n.elementAt(bJ)).f;
                ai1[1] = ((y)(y)bT.n.elementAt(bJ + 1)).f;
                ai1[5] = ((y)(y)bT.n.elementAt(bJ + 2)).f;
                ai1[6] = ((y)(y)bT.n.elementAt(bJ + 3)).f;
                ai1[7] = ((y)(y)bT.n.elementAt(bJ + 4)).f;
                ai1[9] = ((y)(y)bT.n.elementAt(bJ + 5)).f;
                ai1[10] = ((y)(y)bT.n.elementAt(bJ + 6)).f;
                ai1[11] = ((y)(y)bT.n.elementAt(bJ + 7)).f;
                ai1[12] = ((y)(y)bT.n.elementAt(bJ + 8)).f;
                ai1[13] = ((y)(y)bT.n.elementAt(bJ + 9)).f;
                for(i1 = 0; i1 < 14; i1++)
                    if(t[i1] != ai1[i1])
                    {
                        t[i1] = ai1[i1];
                        flag = true;
                    }

            }
            if((i1 = bT.d(bp)) != dd)
            {
                dd = i1;
                al(dd);
                ce.a(dd);
                flag = true;
            }
            if(bT.c(bq))
                h = 1;
            else
                h = 0;
            boolean flag1 = false;
            if(bT.c(bq + 1))
                i1 = 1;
            else
                i1 = 0;
            if(i1 != i)
            {
                i = i1;
                flag1 = true;
            }
            if(i1 != 0 && (i1 = bT.d(bs)) != j)
            {
                j = (byte)i1;
                flag1 = true;
            }
            if(bT.c(br))
                i1 = 1;
            else
                i1 = 0;
            if(i1 != cZ)
            {
                cZ = i1;
                flag1 = true;
            }
            if(g.d)
                if(bT.c(br + 1))
                {
                    cY = 1;
                    g.a(l);
                } else
                {
                    cY = 0;
                }
            String s1;
            if(g.e && (s1 = bT.e(aA)).length() != 0)
                try
                {
                    if((s1 = Integer.parseInt(s1)) >= 0 && s1 <= 100)
                        l = (byte)s1;
                }
                catch(Exception _ex) { }
            if(flag1)
            {
                ea();
                bT = null;
            }
            break;

        case 13: // '\r'
            if(aG)
            {
                if(bT.c(1))
                    A = 1;
                else
                    A = 0;
                if(bT.c(bt))
                    cR = 1;
                else
                    cR = 0;
                if(bT.c(bt + 1))
                    cS = 1;
                else
                    cS = 0;
                if(bT.c(bt + 2))
                    cT = 1;
                else
                    cT = 0;
                if(bT.c(bt + 3))
                    cU = 1;
                else
                    cU = 0;
                String s2;
                int j1;
                if((s2 = bT.e(az)).length() != 0)
                    try
                    {
                        if((j1 = Integer.parseInt(s2)) >= 0 && j1 <= 100)
                            k = j1;
                    }
                    catch(Exception _ex) { }
                if((j1 = bT.e(bt + 5)).length() != 0)
                    try
                    {
                        if((j1 = Integer.parseInt(j1)) >= 1 && j1 <= 100)
                            cV = (byte)j1;
                    }
                    catch(Exception _ex) { }
            }
            break;

        case 14: // '\016'
            if(aF)
            {
                if(bT.c(bu))
                    cW = 1;
                else
                    cW = 0;
                if(bT.c(bu + 1))
                    cX = 1;
                else
                    cX = 0;
                if(bT.c(bv))
                    df = 1;
                else
                    df = 0;
                if(bT.c(bv + 1))
                    dg = 1;
                else
                    dg = 0;
            }
            break;

        case 15: // '\017'
            if(aC)
                aR = s3 = bT.e(1);
            break;
        }
        if(flag)
        {
            a();
            return true;
        } else
        {
            return false;
        }
    }

    private Vector v(String s1)
    {
        FileConnection fileconnection;
        Vector vector;
        int i1;
        fileconnection = null;
        vector = new Vector();
        i1 = 0;
        if("/".equals(s1))
        {
            this = FileSystemRegistry.listRoots();
        } else
        {
            String s2 = aQ + s1;
            Object obj = null;
            Object obj1 = null;
            XConnection xconnection = new XConnection();
            if(s2.startsWith("sms"))
                obj1 = xconnection;
            else
                obj1 = Connector.open(s2);
            this = (fileconnection = (FileConnection)obj1).list();
            vector.addElement("..");
            i1 = 1;
        }
        while(hasMoreElements()) 
            if((s1 = (String)nextElement()).charAt(s1.length() - 1) == '/')
            {
                if(i1 >= vector.size())
                    vector.addElement(s1);
                else
                    vector.insertElementAt(s1, i1);
                i1++;
            } else
            {
                vector.addElement(s1);
            }
        if(fileconnection != null)
            fileconnection.close();
          goto _L1
        JVM INSTR dup ;
        s1;
        printStackTrace();
_L1:
        return vector;
    }

    final void v()
    {
        Vector vector = v(eP);
        eQ = null;
        eQ = new o(eP, dl, dw, dx, dy, dz, dn, dd, 0);
        for(this = 0; this < vector.size(); this++)
        {
            String s1;
            if((s1 = (String)vector.elementAt(this)).compareTo("..") == 0)
            {
                eQ.d(s1, 1);
                continue;
            }
            if(s1.charAt(s1.length() - 1) == '/')
            {
                eQ.d(s1, 1);
                continue;
            }
            String s2 = s1.toLowerCase();
            if(eR == 2)
            {
                if(s2.endsWith(".dict") || s2.compareTo("dat0") == 0)
                    eQ.d(s1, 2);
                continue;
            }
            if(eR == 3)
            {
                if(s2.startsWith("record") && s2.endsWith(".dat"))
                    eQ.d(s1, 2);
                continue;
            }
            if(eR == 4)
            {
                if(s2.endsWith(".txt"))
                    eQ.d(s1, 2);
                continue;
            }
            if(eR == 1 || eR == 7)
            {
                if(s2.endsWith(".jyb") || s2.endsWith(".lrc") || s2.endsWith(".txt"))
                {
                    eQ.d(s1, 11);
                    continue;
                }
                if(s2.endsWith(".mp3") || s2.endsWith(".amr") || s2.endsWith(".wav") || s2.endsWith(".aac"))
                {
                    eQ.d(s1, 12);
                    continue;
                }
                if(s2.endsWith(".3gp"))
                {
                    eQ.d(s1, 13);
                    continue;
                }
                if(eR == 1)
                    eQ.d(s1, 2);
            } else
            {
                eQ.d(s1, 2);
            }
        }

        if(eR == 7)
        {
            if(be.compareTo(aW) == 0)
                eQ.a(aZ, bf);
            else
            if(bf.compareTo(aW) == 0)
                eQ.a(be, aZ);
            else
                eQ.a(be, bf);
        } else
        {
            eQ.a(be, bf);
        }
        eQ.z = true;
        f = eQ;
        v.e();
        v.repaint();
    }

    final void b(String s1)
    {
        if(eP.equals("/"))
        {
            if(s1.equals(".."))
                return;
            eP = s1;
        } else
        if(s1.equals(".."))
        {
            if((s1 = eP.lastIndexOf('/', eP.length() - 2)) != -1)
                eP = eP.substring(0, s1 + 1);
            else
                eP = "/";
        } else
        {
            eP = eP + s1;
        }
        v();
    }

    private static void a(byte abyte0[], int i1, int j1)
    {
        int k1;
        if((k1 = j1 & 0xff) > 128)
            k1 -= 256;
        abyte0[i1++] = (byte)k1;
        if((k1 = j1 >> 8 & 0xff) > 128)
            k1 -= 256;
        abyte0[i1] = (byte)k1;
    }

    private static int e(byte abyte0[], int i1)
    {
        int j1;
        if((j1 = abyte0[i1++]) < 0)
            j1 += 256;
        if((abyte0 = abyte0[i1]) < 0)
            abyte0 += 256;
        return abyte0 << 8 | j1;
    }

    private static void a(ByteArrayOutputStream bytearrayoutputstream, int i1)
    {
        byte abyte0[] = new byte[2];
        int j1;
        if((j1 = i1 & 0xff) > 128)
            j1 -= 256;
        abyte0[0] = (byte)j1;
        if((j1 = i1 >> 8) > 128)
            j1 -= 256;
        abyte0[1] = (byte)j1;
        bytearrayoutputstream.write(abyte0, 0, 2);
    }

    private static void b(ByteArrayOutputStream bytearrayoutputstream, int i1)
    {
        byte abyte0[] = new byte[4];
        int j1;
        if((j1 = i1 & 0xff) > 128)
            j1 -= 256;
        abyte0[0] = (byte)j1;
        if((j1 = i1 >> 8 & 0xff) > 128)
            j1 -= 256;
        abyte0[1] = (byte)j1;
        if((j1 = i1 >> 16 & 0xff) > 128)
            j1 -= 256;
        abyte0[2] = (byte)j1;
        if((j1 = i1 >> 24) > 128)
            j1 -= 256;
        abyte0[3] = (byte)j1;
        bytearrayoutputstream.write(abyte0, 0, 4);
    }

    private static void b(ByteArrayOutputStream bytearrayoutputstream, String s1)
    {
        int i1 = s1.length();
        a(bytearrayoutputstream, i1 << 1);
        for(int j1 = 0; j1 < i1; j1++)
        {
            char c1 = s1.charAt(j1);
            a(bytearrayoutputstream, c1);
        }

    }

    static int a(byte byte0)
    {
        if(byte0 >= 0)
            return byte0;
        else
            return byte0 + 256;
    }

    private static int am(int i1)
    {
        if(i1 >= 0)
            return i1;
        else
            return i1 + 256;
    }

    static int a(InputStream inputstream)
    {
        int i1;
        int j1;
        int k1;
        i1 = am(inputstream.read());
        j1 = am(inputstream.read());
        k1 = am(inputstream.read());
        inputstream = am(inputstream.read());
        return i1 | j1 << 8 | k1 << 16 | inputstream << 24;
        JVM INSTR dup ;
        Exception exception;
        exception;
        toString();
        c();
        return 0;
    }

    static int b(InputStream inputstream)
    {
        int i1;
        i1 = am(inputstream.read());
        inputstream = am(inputstream.read());
        return i1 | inputstream << 8;
        JVM INSTR dup ;
        Exception exception;
        exception;
        toString();
        c();
        return 0;
    }

    static int a(byte abyte0[], int i1)
    {
        int j1 = a(abyte0[i1++]);
        int k1 = a(abyte0[i1++]);
        int l1 = a(abyte0[i1++]);
        abyte0 = a(abyte0[i1]);
        return j1 | k1 << 8 | l1 << 16 | abyte0 << 24;
    }

    static int b(byte abyte0[], int i1)
    {
        int j1 = a(abyte0[i1++]);
        abyte0 = a(abyte0[i1]);
        return j1 | abyte0 << 8;
    }

    static String c(byte abyte0[], int i1)
    {
        int j1;
        if((j1 = b(abyte0, i1)) == 0)
            return "";
        char ac1[] = new char[j1 >> 1];
        i1 += 2;
        for(int k1 = 0; k1 < j1 - 1; k1 += 2)
        {
            int l1;
            l1 = (char)(l1 = a(abyte0[i1 + k1]) + (a(abyte0[i1 + k1 + 1]) << 8));
            ac1[k1 >> 1] = l1;
        }

        return abyte0 = new String(ac1, 0, j1 >> 1);
    }

    static void w()
    {
        try
        {
            int j1 = 1;
            String s1 = aR + "unicode.map";
            Object obj = null;
            Object obj1 = null;
            XConnection xconnection = new XConnection();
            if(s1.startsWith("sms"))
                obj1 = xconnection;
            else
                obj1 = Connector.open(s1, j1);
            FileConnection fileconnection;
            InputStream inputstream = (fileconnection = (FileConnection)obj1).openInputStream();
            int i1;
            M = new byte[i1 = (int)fileconnection.fileSize()];
            System.out.println("gbk2unicode_table.length:" + M.length);
            inputstream.read(M);
            inputstream.close();
            fileconnection.close();
            N = -1;
            return;
        }
        catch(Exception exception)
        {
            N = 1;
            M = null;
            a("rg", exception);
            return;
        }
    }

    static void c(String s1)
    {
        d = d + s1 + "\n";
        System.out.println(s1);
    }

    static void a(String s1, Exception exception)
    {
        c(" *" + s1 + ":" + exception.toString());
    }

    static void d(String s1)
    {
        if(ax == null)
        {
            (ax = new o("提示", dl, dw + dn, dx + dn / 2, dy - (dn << 1), dz - dn, dn, dd, 4, 0)).a(aV, aX);
            ax.b(s1);
            ax.a();
        } else
        {
            ax.a(s1);
            ax.a();
        }
        v.e();
        v.repaint();
    }

    static void a(String s1, String s2, int i1)
    {
        if(ax == null)
        {
            (ax = new o(s1, dl, dw + dn, dx + dn / 2, dy - (dn << 1), dz - dn, dn, dd, 4, i1)).b(s2);
            if(i1 == 3)
            {
                ax.a("是", 21, "否", 22);
                ax.a(bc, bd);
                ax.h(1);
            }
            ax.a();
        } else
        {
            ax.a(s2);
            ax.a();
        }
        v.e();
        v.repaint();
    }

    static String e(String s1)
    {
        StringBuffer stringbuffer = new StringBuffer();
        for(int i1 = 0; i1 < s1.length(); i1++)
        {
            int j1 = s1.charAt(i1);
            if(dg == 0)
            {
                switch(j1)
                {
                case 97: // 'a'
                    j1 = 1;
                    break;

                case 98: // 'b'
                    j1 = 2;
                    break;

                case 67: // 'C'
                    j1 = 3;
                    break;

                case 100: // 'd'
                    j1 = 4;
                    break;

                case 101: // 'e'
                    j1 = 5;
                    break;

                case 102: // 'f'
                    j1 = 6;
                    break;

                case 103: // 'g'
                    j1 = 7;
                    break;

                case 104: // 'h'
                    j1 = 8;
                    break;

                case 105: // 'i'
                    j1 = 9;
                    break;

                case 106: // 'j'
                    j1 = 10;
                    break;

                case 107: // 'k'
                    j1 = 11;
                    break;

                case 108: // 'l'
                    j1 = 12;
                    break;

                case 109: // 'm'
                    j1 = 13;
                    break;

                case 110: // 'n'
                    j1 = 14;
                    break;

                case 79: // 'O'
                    j1 = 15;
                    break;

                case 111: // 'o'
                    j1 = 15;
                    break;

                case 112: // 'p'
                    j1 = 16;
                    break;

                case 81: // 'Q'
                    j1 = 17;
                    break;

                case 114: // 'r'
                    j1 = 18;
                    break;

                case 115: // 's'
                    j1 = 19;
                    break;

                case 116: // 't'
                    j1 = 20;
                    break;

                case 117: // 'u'
                    j1 = 21;
                    break;

                case 118: // 'v'
                    j1 = 22;
                    break;

                case 119: // 'w'
                    j1 = 23;
                    break;

                case 40: // '('
                    j1 = 24;
                    break;

                case 41: // ')'
                    j1 = 25;
                    break;

                case 122: // 'z'
                    j1 = 26;
                    break;

                case 68: // 'D'
                    j1 = 27;
                    break;

                case 88: // 'X'
                    j1 = 27;
                    break;

                case 65: // 'A'
                    j1 = 28;
                    break;

                case 69: // 'E'
                    j1 = 29;
                    break;

                case 82: // 'R'
                    j1 = 30;
                    break;

                case 83: // 'S'
                    j1 = 31;
                    break;

                case 74: // 'J'
                    j1 = 32;
                    break;

                case 78: // 'N'
                    j1 = 33;
                    break;

                case 32: // ' '
                    j1 = 34;
                    break;

                case 39: // '\''
                    j1 = 35;
                    break;

                case 44: // ','
                    j1 = 36;
                    break;

                case 58: // ':'
                    j1 = 37;
                    break;

                case 59: // ';'
                    j1 = 38;
                    break;

                case 45: // '-'
                    j1 = 39;
                    break;

                case 96: // '`'
                    j1 = 40;
                    break;

                case 33: // '!'
                case 34: // '"'
                case 35: // '#'
                case 36: // '$'
                case 37: // '%'
                case 38: // '&'
                case 42: // '*'
                case 43: // '+'
                case 46: // '.'
                case 47: // '/'
                case 48: // '0'
                case 49: // '1'
                case 50: // '2'
                case 51: // '3'
                case 52: // '4'
                case 53: // '5'
                case 54: // '6'
                case 55: // '7'
                case 56: // '8'
                case 57: // '9'
                case 60: // '<'
                case 61: // '='
                case 62: // '>'
                case 63: // '?'
                case 64: // '@'
                case 66: // 'B'
                case 70: // 'F'
                case 71: // 'G'
                case 72: // 'H'
                case 73: // 'I'
                case 75: // 'K'
                case 76: // 'L'
                case 77: // 'M'
                case 80: // 'P'
                case 84: // 'T'
                case 85: // 'U'
                case 86: // 'V'
                case 87: // 'W'
                case 89: // 'Y'
                case 90: // 'Z'
                case 91: // '['
                case 92: // '\\'
                case 93: // ']'
                case 94: // '^'
                case 95: // '_'
                case 99: // 'c'
                case 113: // 'q'
                case 120: // 'x'
                case 121: // 'y'
                default:
                    j1 = 34;
                    break;
                }
                stringbuffer.append((char)(j1 | 0xfa00));
                continue;
            }
            switch(j1)
            {
            case 67: // 'C'
                j1 = 596;
                break;

            case 79: // 'O'
                j1 = 601;
                break;

            case 111: // 'o'
                j1 = 601;
                break;

            case 81: // 'Q'
                j1 = 952;
                break;

            case 68: // 'D'
                j1 = 230;
                break;

            case 88: // 'X'
                j1 = 230;
                break;

            case 65: // 'A'
                j1 = 652;
                break;

            case 69: // 'E'
                j1 = 603;
                break;

            case 82: // 'R'
                j1 = 240;
                break;

            case 83: // 'S'
                j1 = 643;
                break;

            case 74: // 'J'
                j1 = 658;
                break;

            case 78: // 'N'
                j1 = 331;
                break;

            case 39: // '\''
                j1 = 712;
                break;

            case 96: // '`'
                j1 = 716;
                break;

            default:
                j1 = j1;
                break;
            }
            stringbuffer.append((char)j1);
        }

        return new String(stringbuffer);
    }

    static String f(String s1)
    {
        StringBuffer stringbuffer = new StringBuffer();
        for(int i1 = 0; i1 < s1.length(); i1++)
        {
            char c1 = s1.charAt(i1);
            int j1 = 0;
            switch(c1)
            {
            case 952: 
                j1 = 64017;
                break;

            case 230: 
                j1 = 64027;
                break;

            case 652: 
                j1 = 64028;
                break;

            case 240: 
                j1 = 64030;
                break;

            case 643: 
                j1 = 64031;
                break;

            case 658: 
                j1 = 64032;
                break;

            case 331: 
                j1 = 64033;
                break;

            case 650: 
                j1 = 64021;
                break;

            case 7452: 
                j1 = 64021;
                break;

            case 603: 
                j1 = 64029;
                break;

            case 593: 
                j1 = 64001;
                break;

            case 594: 
                j1 = 64003;
                break;

            case 596: 
                j1 = 64003;
                break;

            case 1241: 
                j1 = 64015;
                break;

            case 17: // '\021'
                j1 = 64015;
                break;

            case 601: 
                j1 = 64015;
                break;

            case 604: 
                j1 = 64015;
                break;

            case 605: 
                j1 = 64015;
                break;

            case 602: 
                j1 = 64015;
                break;

            case 618: 
                j1 = 64009;
                break;

            case 1108: 
                j1 = 64029;
                break;

            case 720: 
                j1 = 64037;
                break;

            case 719: 
                j1 = 64040;
                break;

            case 716: 
                j1 = 64040;
                break;

            case 715: 
                j1 = 64035;
                break;

            case 714: 
                j1 = 64035;
                break;

            case 712: 
                j1 = 64035;
                break;
            }
            if(j1 > 0)
                stringbuffer.append((char)j1);
            else
                stringbuffer.append(c1);
        }

        return new String(stringbuffer);
    }

    final int g(String s1)
    {
        String s2;
        String s3;
        String s4;
label0:
        {
            s3 = "";
            s4 = "";
            int i1;
            if((i1 = s1.indexOf("[")) >= 0)
            {
                s2 = s1.substring(0, i1);
                int l1;
                if((l1 = s1.indexOf("]", i1 + 1)) >= 0)
                {
                    s3 = s1.substring(i1 + 1, l1);
                    s4 = s1.substring(l1 + 1, s1.length());
                }
            } else
            if((i1 = s1.indexOf(",")) >= 0)
            {
                s2 = s1.substring(0, i1);
                s4 = s1.substring(i1 + 1, s1.length());
            } else
            {
                s2 = s1;
            }
            if(s2.length() != 0)
            {
                if(s2.compareTo(fg) == 0)
                    return fh;
                G = 1;
                co = false;
                H = false;
                cc.a(s2);
                fg = s2;
                if(s2.toLowerCase().compareTo(cc.m.toLowerCase()) == 0)
                {
                    int j1 = x;
                    s1 = cc;
                    cc.r = j1;
                    cc.a(x);
                    fh = x;
                    s1 = 1;
                    break label0;
                }
            }
            s1 = 0;
        }
        if(s1 == 0)
        {
            int k1 = -1;
            s1 = cc;
            cc.r = k1;
            fh = -1;
            cc.m = s2;
            cc.n = s3;
            if(s4.length() > 0)
                cc.o = s4;
            else
                cc.o = "(没有解释)";
        } else
        {
            if(s3.length() > 0)
                cc.n = s3;
            if(s4.length() > 0)
                cc.o = s4;
        }
        return fh;
    }

    final void x()
    {
        (new Thread(new t(this))).start();
    }

    final void y()
    {
        String s1;
        if((s1 = ((ai)eg.elementAt(bL)).b).length() == 0)
        {
            cd = cc;
            break MISSING_BLOCK_LABEL_75;
        }
        cd = new s(s1);
        if(cd.d == null)
        {
            cd = cc;
            return;
        }
        return;
        JVM INSTR pop ;
        cd = cc;
    }

    final void z()
    {
label0:
        {
label1:
            {
                int i1 = bN.q();
                i1 = bN.f(i1);
                ag ag1;
                String s5;
                if((s5 = (ag1 = (ag)em.elementAt(i1)).a).compareTo("..") == 0)
                {
                    if(i1 <= 0)
                        bO = 0;
                    else
                        bO = i1 - 1;
                    e();
                    return;
                }
                if((s5 = ag1.b).endsWith("/"))
                {
                    if(i1 + 1 >= em.size())
                        return;
                    ag ag2 = (ag)em.elementAt(i1 + 1);
                    if(ag1.c + 1 != ag2.c)
                    {
                        return;
                    } else
                    {
                        bO = i1 + 1;
                        e();
                        return;
                    }
                }
                ag = ag1;
                String s7 = s5.toLowerCase();
                Object obj = null;
                ag1 = null;
                Object obj2 = null;
                if(s7.endsWith(".mp3") || s7.endsWith(".amr") || s7.endsWith(".wav") || s7.endsWith(".aac"))
                {
                    ah = null;
                    ai = false;
                    String s1 = s5;
                    dI.c();
                    String s3 = ag.a("TIME");
                    String s8 = "";
                    a(s1, s3, s8);
                    I();
                    break label0;
                }
                if((ah = new s(s5)).b == ' ')
                    return;
                if(ah.b == 'Z')
                {
                    if(!ah.l)
                    {
                        ai = true;
                        break label1;
                    }
                } else
                {
                    if(ah.d.z);
                    if(ah.b == 'b')
                    {
                        ai = true;
                        break label1;
                    }
                }
                ai = false;
            }
            Object obj1 = ag.a("AUDIOFILE");
            ah.p = ((String) (obj1));
            int j1 = 0;
            boolean flag = false;
            String s6;
            if((s6 = ag.a("ORG")) != null && s6.length() > 0)
                try
                {
                    if((j1 = Integer.parseInt(s6)) == 0)
                        ah.u = false;
                }
                catch(Exception _ex) { }
            int k1 = j1;
            j1 = ah;
            ah.q = k1;
            if(flag)
            {
                bP = 1;
                H();
            } else
            {
                ah.b(ah.r);
                if(ah.l)
                {
                    String s2;
                    if(ah.p.length() == 0)
                        if((s2 = h(ah.a)).length() != 0)
                        {
                            ah.p = s2;
                        } else
                        {
                            d("提示:未找到音频文件！请将此课件的音频文件拷贝到课件所在同一文件夹内。");
                            ah.l = false;
                        }
                    if(ah.p.length() != 0)
                    {
                        String s4 = K();
                        String s9 = K();
                        dI.c();
                        a(ah.p, s4, s9);
                    }
                }
                I();
            }
        }
        A();
        v.e();
        v.repaint();
    }

    static String h(String s1)
    {
        String as1[];
        int i1;
        s1 = s1.substring(0, s1.length() - 4);
        as1 = (new String[] {
            ".mp3", ".amr", ".wav"
        });
        i1 = 0;
_L3:
        if(i1 >= as1.length) goto _L2; else goto _L1
_L1:
        String s2 = s1 + as1[i1];
        Object obj1;
        String s3 = s2;
        Object obj = null;
        obj1 = null;
        XConnection xconnection = new XConnection();
        if(s3.startsWith("sms"))
            obj1 = xconnection;
        else
            obj1 = Connector.open(s3);
        FileConnection fileconnection;
        if((fileconnection = (FileConnection)obj1).exists())
            return s2;
        try
        {
            fileconnection.close();
        }
        catch(Exception _ex) { }
        i1++;
          goto _L3
_L2:
        return "";
    }

    final void A()
    {
label0:
        {
            for(int i1 = 0; i1 < 7; i1++)
                eD[i1] = 0;

            if(ah == null)
            {
                if(dJ && dK == 1)
                    eD[2] = 3;
                else
                    eD[1] = 2;
                eD[3] = 5;
                eD[4] = 6;
                break label0;
            }
            eD[0] = 0xff0001;
            if(ah.l)
            {
                if(dJ && dK == 1)
                    eD[2] = 0xff0003;
                else
                    eD[1] = 0xff0002;
                eD[3] = 0xff0005;
                eD[4] = 0xff0006;
            }
            if(!ah.k)
                break label0;
            if(ai)
            {
                if(!ah.u)
                {
                    eD[5] = 0xff0007;
                    break label0;
                }
            } else
            {
                if(ah.u)
                    eD[5] = 0xa00007;
                else
                    eD[5] = 0xff0007;
                if(ah.v)
                {
                    eD[6] = 0xa00008;
                    break label0;
                }
            }
            eD[6] = 0xff0008;
        }
        (ek = new o(null, dl, dw, dx, dy, dz, dn, dd, 1)).a(0xffffee, 0, 192, 0xffffff);
        ek.a(eC, eD);
        ek.a();
    }

    final void B()
    {
        if(dK == 1)
        {
            F();
            dK = 3;
        }
        bw.setTitle("指定媒体时间");
        bw.setString(a.a(E()));
        bx = 'T';
        cb.setCurrent(bw);
    }

    final void C()
    {
        if(dI.c == 3)
        {
            dI.c = 0;
            dI.e = -1L;
            dI.d = -1L;
        }
        if(dI.e > 0L)
        {
            dI.c = 0;
            dI.e = -1L;
            dI.d = -1L;
        } else
        if(dI.d >= 0L)
        {
            dI.c = 2;
            dI.e = E();
        } else
        {
            dI.c = 1;
            dI.d = E();
            s s1;
            if(ah != null)
                dI.f = (s1 = ah).r;
        }
        if(ah == null)
        {
            I();
            v.e();
            v.repaint();
        }
    }

    final void a(String s1, String s2, String s3)
    {
        if(s1 != null)
        {
            s1.startsWith("file:///");
            s1 = s1;
            s2 = s2;
            s3 = s3;
            dL = 0;
            dJ = true;
            dK = 0;
            (new Thread(new u(this, s1, s2, s3))).start();
        }
    }

    static boolean D()
    {
        if(ah == null)
            return dK == 1;
        return dK == 1;
    }

    final void i(String s1)
    {
        long l1 = a.b(s1);
        long l2 = a.c(s1);
        dI.b = -1L;
        if(D())
        {
            if(l2 > 0L)
                dI.b = l2;
            a(l1);
            return;
        }
        if(l2 > 0L)
            dI.b = l2;
        dI.h = l1;
    }

    static void a(long l1)
    {
        try
        {
            if(aI == 2)
            {
                dI.i = 0;
                dI.a();
                dI.h = l1;
                dK = 4;
            } else
            {
                long l2;
                if(Math.abs((l2 = dI.a.setMediaTime(l1)) - l1) > 0x1e8480L)
                {
                    dI.a();
                    dI.h = l1;
                    dK = 4;
                    aI = 2;
                }
                return;
            }
        }
        catch(Exception _ex)
        {
            c("[smt" + l1 + "]");
        }
    }

    final long E()
    {
        if(D())
            return dI.f();
        else
            return dI.h;
    }

    final void F()
    {
        if(dK == 1 && dI != null)
        {
            dI.a();
            dK = 2;
            A();
        }
    }

    final void G()
    {
        if(dK != 2 && dK != 3 && dK != 4 || dI == null)
            break MISSING_BLOCK_LABEL_160;
        if(dI.a == null)
            break MISSING_BLOCK_LABEL_97;
        try
        {
            dI.a(dI.h);
        }
        catch(Exception exception)
        {
            a("sp", exception);
        }
        Object obj;
        if(((n) (obj = dI)).a == null) goto _L2; else goto _L1
_L1:
        ((n) (obj)).a.start();
          goto _L2
        JVM INSTR dup ;
        obj;
        toString();
        c();
_L2:
        dK = 1;
        break MISSING_BLOCK_LABEL_156;
        dK = 0;
        if(ah != null)
            a(dI.g, a.a(dI.h), ah.x);
        else
            a(dI.g, a.a(dI.h), "");
        A();
    }

    static void H()
    {
        bQ = null;
        (bQ = new o("目录", dl, dw, dx, dy, dz, dn, dd, 0)).a(be, bf);
        s s1;
        int i1 = (s1 = ah).r;
        int j1 = -1;
        int k1 = 0;
        int l1 = ah.f;
        if(ah.b == 'B' || ah.b == 'b' || ah.b == 'Z')
        {
            if(ai && ah.k && ah.h > 0)
                if(ah.u)
                    l1 = ah.h;
                else
                    k1 = ah.h;
            for(int i2 = k1; i2 < l1; i2++)
            {
                String s2 = ah.i[i2];
                int j2 = ah.j[i2];
                bQ.e(s2, j2);
                if(j1 < 0 && i1 <= j2)
                    j1 = i2 - k1 - 1;
            }

        }
        if(j1 < 0)
            j1 = l1 - k1 - 1;
        bQ.i(j1);
        f = bQ;
    }

    final void I()
    {
        bR = null;
        (bR = new o("课件", dl, dw, dx, dy, dz, dn, dd, 0)).a(aV, aX);
        if(dJ)
        {
            if(ah == null)
            {
                String s1;
                if((s1 = ag.b).startsWith("file:///"))
                    s1 = s1.substring(8, s1.length());
                else
                if(s1.startsWith("file://"))
                    s1 = s1.substring(7, s1.length());
                bR.a("文件: " + s1);
                if(A != 0)
                    bR.a("音量: " + k + "%");
                else
                    bR.a("静音");
            }
            if(ah == null && dI.c > 0)
            {
                if(dI.d >= 0L)
                    bR.a("A:" + a.a(dI.d));
                if(dI.e >= 0L)
                    bR.a("B:" + a.a(dI.e));
            }
        }
        if(ah != null)
            if(ai)
            {
                bR.s = 0;
                int i1 = !ah.u || !ah.k ? ah.e : ah.g;
                int j1 = ah.r;
                int k1 = bR.r;
                fj = new Vector();
                do
                {
                    int i2 = j1;
                    s s2 = ah;
                    ah.r = i2;
                    ah.b(j1);
                    int l1 = bR.y;
                    i2 = bR.n.size();
                    if(ah.y != null)
                        bR.h(ah.y, I[5]);
                    if(ah.z != null && ah.u)
                        bR.h(ah.z, I[12]);
                    if(ah.A != null && ah.v)
                        bR.h(ah.A, I[13]);
                    fj.addElement(new af(j1, bR.n.size() - i2, bR.y - l1));
                    if(j1 + 1 >= i1 || bR.y >= k1)
                        break;
                    j1++;
                } while(true);
            } else
            {
                ah.b(ah.r);
                if(ah.y != null)
                    bR.h(ah.y, I[5]);
                if(ah.z != null && ah.u)
                    bR.h(ah.z, I[12]);
                if(ah.A != null && ah.v)
                    bR.h(ah.A, I[13]);
                if(ah.C != null)
                    bR.h(ah.C, I[9]);
                if(ah.B != null)
                    bR.h(ah.B, I[5]);
            }
        bR.h(0);
        bR.B = false;
        f = bR;
        ea = false;
    }

    static int J()
    {
        s s1;
        if(!ai)
            return (s1 = ah).r;
        int i1 = 0;
        int j1 = bR.x;
        for(int k1 = 0; k1 < fj.size(); k1++)
        {
            af af1 = (af)fj.elementAt(k1);
            i1 += af1.c;
            if(j1 < i1)
                return af1.a;
        }

        return ((af)(af)fj.elementAt(fj.size() - 1)).a;
    }

    static String K()
    {
        String s1;
        if((s1 = ah.x) != null)
            return s1;
        else
            return "";
    }

    private static String w(String s1)
    {
        int i1;
        if((i1 = s1.indexOf("[")) >= 0)
            s1 = s1.substring(0, i1);
        else
        if((i1 = s1.indexOf(",")) >= 0)
            s1 = s1.substring(0, i1);
        else
            s1 = s1;
        return s1;
    }

    final int a(int i1, String s1)
    {
        i1 = super.c;
        if(super.b == 0)
        {
            i1.addElement(s1);
        } else
        {
            boolean flag = false;
            String s2 = w(s1);
            int j1 = 0;
            do
            {
                if(j1 >= i1.size())
                    break;
                String s3 = w((String)i1.elementAt(j1));
                if(s2.compareTo(s3) == 0)
                {
                    flag = true;
                    break;
                }
                j1++;
            } while(true);
            if(flag)
                return 1;
            if(super.d + 1 == super.b)
            {
                i1.addElement(s1);
                super.d++;
            } else
            {
                i1.insertElementAt(s1, super.d + 1);
                super.d++;
            }
        }
        super.b++;
        return 0;
    }

    private static String a(int i1, int j1)
    {
        j1 = (i1 = "00000" + Integer.toString(i1)).length();
        return i1.substring(j1 - 5, j1);
    }

    final void L()
    {
        G = 1;
        co = false;
        H = false;
        String s1;
        int i1;
        if((i1 = (s1 = cd.m.toLowerCase()).indexOf('[')) > 0)
            s1 = s1.substring(0, i1).trim();
        cc.a(s1);
        if(s1.compareTo(cc.m.toLowerCase()) == 0)
        {
            int j1 = x;
            s s2 = cc;
            cc.r = j1;
            cc.a(x);
            fi = x;
            return;
        } else
        {
            fi = -1;
            return;
        }
    }

    static boolean M()
    {
        return cm == 2 && cF == 1 || cm == 3 && cJ == 1 || cm == 4 && eb == 2 && cN == 1;
    }

    static boolean N()
    {
        return cm == 2 && cF == 2 || cm == 3 && cJ == 2 || cm == 4 && eb == 2 && cN == 2;
    }

    static boolean O()
    {
        return cm == 2 && cF == 3 || cm == 3 && cJ == 3 || cm == 4 && eb == 2 && cN == 3;
    }

    final boolean P()
    {
        if(!aH)
            return false;
        return N() && !cr && f == ci || cm == 1 && cn && f == ce;
    }

    private static void x(String s1)
    {
        s1 = new w(s1);
        if(ec.size() == 0)
        {
            ec.addElement(s1);
            return;
        }
        if(ed + 1 == ec.size())
        {
            ec.addElement(s1);
            ed++;
            return;
        } else
        {
            ec.insertElementAt(s1, ed + 1);
            ed++;
            return;
        }
    }

    final void a(String s1, int i1)
    {
        G = 1;
        co = false;
        cg = false;
        ar = new StringBuffer();
        au = false;
        cq = s1;
        (new Thread(new k(this, i1))).start();
    }

    final void Q()
    {
        String s1 = eQ.e(eQ.q());
        int i1 = 0;
        int j1 = 0;
        byte byte0 = 0;
        if(em.size() > 0)
        {
            i1 = bN.q();
            i1 = bN.f(i1);
            ag ag1;
            byte0 = (ag1 = (ag)em.elementAt(i1)).c;
            if(ag1.b.endsWith("/"))
            {
                boolean flag = false;
                int k1 = i1 + 1;
                do
                {
                    if(k1 >= em.size())
                        break;
                    ag ag2;
                    if((ag2 = (ag)em.elementAt(k1)).c <= byte0)
                    {
                        flag = true;
                        j1 = k1;
                        break;
                    }
                    k1++;
                } while(true);
                if(!flag)
                    j1 = em.size();
            } else
            {
                j1 = i1 + 1;
            }
        }
        if(s1.endsWith("/"))
        {
            String s2 = aQ + eP + s1;
            String s4 = s1.substring(0, s1.length() - 1);
            ag ag3;
            (ag3 = new ag(s4, s2)).c = byte0;
            int i2 = j1;
            em.insertElementAt(ag3, j1);
            j1++;
            (ag3 = new ag("..", s2)).c = (byte)(byte0 + 1);
            em.insertElementAt(ag3, j1);
            j1++;
            Vector vector = v(eP + s1);
            for(int l1 = 0; l1 < vector.size(); l1++)
            {
                Object obj;
                String s5;
                if(!(s5 = ((String) (obj = (String)vector.elementAt(l1))).toLowerCase()).endsWith(".jyb") && !s5.endsWith(".lrc") && !s5.endsWith(".mbk") && !s5.endsWith(".txt"))
                    continue;
                String s3 = aQ + eP + s1 + obj;
                if(s5.endsWith(".lrc") || s5.endsWith(".mbk") || s5.endsWith(".txt"))
                {
                    s5 = s3.substring(s3.lastIndexOf('/') + 1, s3.length());
                } else
                {
                    ((a) (obj = new a(s3))).a(false);
                    ((a) (obj)).a();
                    if(18 < ((a) (obj)).i || ((a) (obj)).f != 66 && ((a) (obj)).f != 98)
                        continue;
                    s5 = ((a) (obj)).j;
                }
                (obj = new ag(s5, s3)).c = (byte)(byte0 + 1);
                em.insertElementAt(obj, j1);
                j1++;
            }

            bO = i2;
            e();
            v.e();
            v.repaint();
            return;
        }
        s3 = j1;
        byte byte1 = byte0;
        String s6 = aQ + eP + s1;
        for(int j2 = 0; j2 < em.size(); j2++)
        {
            ag ag4 = (ag)em.elementAt(j2);
            if(s6.compareTo(ag4.b) == 0)
            {
                d("课件列表中已有该课件");
                return;
            }
        }

        String s7;
        String s8;
        if((s8 = s6.toLowerCase()).endsWith(".mp3") || s8.endsWith(".amr") || s8.endsWith(".wav") || s8.endsWith(".aac"))
            s7 = s1;
        else
        if(s8.endsWith(".lrc") || s8.endsWith(".mbk") || s8.endsWith(".txt"))
        {
            s7 = s6.substring(s6.lastIndexOf('/') + 1, s6.length());
        } else
        {
            a a1;
            (a1 = new a(s6)).a(false);
            a1.a();
            if(18 < a1.i)
            {
                d("请升级软件后才能打开此课件");
                return;
            }
            if(a1.f != 66 && a1.f != 98)
            {
                d("课件格式不对");
                return;
            }
            s7 = a1.j;
        }
        ag ag5;
        (ag5 = new ag(s7, s6)).c = byte1;
        em.insertElementAt(ag5, s3);
        bO = s3;
        e();
        v.e();
        v.repaint();
    }

    static String R()
    {
        return cq;
    }

    static void a(MemoDictMIDlet memodictmidlet, String s1)
    {
        s1 = s1;
        memodictmidlet = memodictmidlet;
        H = false;
        if(cm == 1)
        {
            if(co)
            {
                int i1 = 0;
                w = 0;
                memodictmidlet.ch = null;
                memodictmidlet.ch = new o(null, dl, dw, dx, dy, dz, dn, dd, 0);
                memodictmidlet.ch.a(aV, aX);
                z = memodictmidlet.cd.e / dq;
                eU = -1;
                f = memodictmidlet.ch;
                v.e();
                v.repaint();
                v.serviceRepaints();
                do
                {
                    memodictmidlet.cd.a(s1);
                    if(w < 0)
                        break;
                    s s2;
                    memodictmidlet.ch.e((s2 = memodictmidlet.cd).m + " " + f(y), w);
                    eU = (w * dq) / memodictmidlet.cd.e;
                    v.e();
                    v.repaint();
                    v.serviceRepaints();
                    if(++i1 >= 100)
                        break;
                    w++;
                } while(true);
                eU = -1;
            } else
            {
                memodictmidlet.cd.a(s1);
                memodictmidlet.aj(x);
                dc = memodictmidlet.ce.f(memodictmidlet.ce.q());
                if(!cn)
                {
                    s1 = dc;
                    s s3 = memodictmidlet.cd;
                    memodictmidlet.cd.r = s1;
                    memodictmidlet.cd.a(dc);
                    if(aF && cW != 0 && memodictmidlet.cd.b == 'J')
                        memodictmidlet.i();
                    else
                        v.f();
                } else
                {
                    f = memodictmidlet.ce;
                    memodictmidlet.r();
                }
            }
            v.e();
            v.repaint();
        }
    }

    static int S()
    {
        return dM++;
    }

    static int T()
    {
        return dN;
    }

    static String j(String s1)
    {
        return dO = s1;
    }

    static int h(int i1)
    {
        return dN = i1;
    }

    static int U()
    {
        return cm;
    }

    static byte V()
    {
        return cI;
    }

    static byte W()
    {
        return cM;
    }

    static int X()
    {
        return eb;
    }

    static byte Y()
    {
        return cQ;
    }

    static String k(String s1)
    {
        return dP = s1;
    }

    static int Z()
    {
        return bL;
    }

    static s a(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.cd;
    }

    static s b(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.cc;
    }

    static int i(int i1)
    {
        return bL = i1;
    }

    static int aa()
    {
        return dM--;
    }

    static boolean ab()
    {
        return T;
    }

    static int ac()
    {
        return cY;
    }

    static i c(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.dH;
    }

    static boolean ad()
    {
        return dJ;
    }

    static int ae()
    {
        return eS;
    }

    static int af()
    {
        return eT;
    }

    static int ag()
    {
        return 0;
    }

    static int ah()
    {
        return dt;
    }

    static int ai()
    {
        return du;
    }

    static int aj()
    {
        return dv;
    }

    static int ak()
    {
        return dK;
    }

    static int al()
    {
        return dL++;
    }

    static n am()
    {
        return dI;
    }

    static s an()
    {
        return ah;
    }

    static int j(int i1)
    {
        return dK = i1;
    }

    static int ao()
    {
        return 0;
    }

    static int ap()
    {
        return 0;
    }

    static int aq()
    {
        return dq;
    }

    static int ar()
    {
        return dr;
    }

    static String as()
    {
        return U;
    }

    static int at()
    {
        return dj;
    }

    static int k(int i1)
    {
        return dj = i1;
    }

    static Image au()
    {
        return di;
    }

    static int av()
    {
        return dk;
    }

    static o aw()
    {
        return ax;
    }

    static o a(o o1)
    {
        return ax = o1;
    }

    static String ax()
    {
        return aY;
    }

    static o ay()
    {
        return bU;
    }

    static o az()
    {
        return bW;
    }

    static o aA()
    {
        return bY;
    }

    static o aB()
    {
        return bS;
    }

    static int aC()
    {
        return cF;
    }

    static int aD()
    {
        return cJ;
    }

    static int aE()
    {
        return cN;
    }

    static boolean aF()
    {
        return cr;
    }

    static o aG()
    {
        return cj;
    }

    static o d(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.ci;
    }

    static o aH()
    {
        return eQ;
    }

    static int aI()
    {
        return eR;
    }

    static o aJ()
    {
        return bT;
    }

    static o e(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.cf;
    }

    static o aK()
    {
        return bK;
    }

    static o aL()
    {
        return bN;
    }

    static o aM()
    {
        return bI;
    }

    static o aN()
    {
        return bQ;
    }

    static int aO()
    {
        return bP;
    }

    static o aP()
    {
        return bR;
    }

    static o b(o o1)
    {
        return bQ = null;
    }

    static o aQ()
    {
        return bD;
    }

    static String aR()
    {
        return aW;
    }

    static int[] f(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.aO;
    }

    static int aS()
    {
        return bl;
    }

    static int aT()
    {
        return cv;
    }

    static int l(int i1)
    {
        return cv = i1;
    }

    static int aU()
    {
        return bm;
    }

    static int aV()
    {
        return cz;
    }

    static int m(int i1)
    {
        return cz = i1;
    }

    static int aW()
    {
        return bn;
    }

    static byte aX()
    {
        return cC;
    }

    static int n(int i1)
    {
        return cD = i1;
    }

    static byte b(byte byte0)
    {
        return cC = byte0;
    }

    static short[] a(short aword0[])
    {
        return cy = aword0;
    }

    static int o(int i1)
    {
        return cB = i1;
    }

    static int p(int i1)
    {
        return db = i1;
    }

    static short[] aY()
    {
        return cy;
    }

    static int aZ()
    {
        return cB;
    }

    static boolean a(boolean flag)
    {
        return fb = flag;
    }

    static boolean b(boolean flag)
    {
        return cr = flag;
    }

    static void a(MemoDictMIDlet memodictmidlet, int i1)
    {
        memodictmidlet.ak(i1);
    }

    static int ba()
    {
        return db;
    }

    static int bb()
    {
        return cA;
    }

    static int bc()
    {
        return bz;
    }

    static int q(int i1)
    {
        return cF = i1;
    }

    static int r(int i1)
    {
        return cJ = i1;
    }

    static int s(int i1)
    {
        return cN = i1;
    }

    static int bd()
    {
        return bA;
    }

    static int t(int i1)
    {
        return cG = i1;
    }

    static int u(int i1)
    {
        return cK = i1;
    }

    static int v(int i1)
    {
        return cO = i1;
    }

    static int be()
    {
        return by;
    }

    static int w(int i1)
    {
        return cs = i1;
    }

    static int x(int i1)
    {
        return cH = i1;
    }

    static int y(int i1)
    {
        return cL = i1;
    }

    static int z(int i1)
    {
        return cP = i1;
    }

    static int bf()
    {
        return bB;
    }

    static byte c(byte byte0)
    {
        return cI = byte0;
    }

    static byte d(byte byte0)
    {
        return da = byte0;
    }

    static byte e(byte byte0)
    {
        return cM = byte0;
    }

    static byte f(byte byte0)
    {
        return cQ = byte0;
    }

    static int bg()
    {
        return dW;
    }

    static boolean[] bh()
    {
        return dS;
    }

    static int bi()
    {
        return bG;
    }

    static boolean[] bj()
    {
        return dT;
    }

    static int bk()
    {
        return bH;
    }

    static int bl()
    {
        return dV;
    }

    static int A(int i1)
    {
        return cm = i1;
    }

    static o bm()
    {
        return bF;
    }

    static String g(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.aQ;
    }

    static String h(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.eP;
    }

    static Alert bn()
    {
        return bj;
    }

    static Display bo()
    {
        return cb;
    }

    static String l(String s1)
    {
        return aR = s1;
    }

    static String bp()
    {
        return aZ;
    }

    static String bq()
    {
        return bb;
    }

    static String br()
    {
        return ba;
    }

    static o c(o o1)
    {
        return eq = o1;
    }

    static o bs()
    {
        return null;
    }

    static boolean c(boolean flag)
    {
        return eO = flag;
    }

    static boolean bt()
    {
        return eO;
    }

    static o i(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.ce;
    }

    static boolean bu()
    {
        return cn;
    }

    static o bv()
    {
        return ef;
    }

    static o bw()
    {
        return ee;
    }

    static o bx()
    {
        return eh;
    }

    static o by()
    {
        return ei;
    }

    static o bz()
    {
        return el;
    }

    static o bA()
    {
        return en;
    }

    static o bB()
    {
        return ep;
    }

    static o bC()
    {
        return eo;
    }

    static o bD()
    {
        return ej;
    }

    static o bE()
    {
        return ek;
    }

    static o bF()
    {
        return bX;
    }

    static o bG()
    {
        return bC;
    }

    static boolean bH()
    {
        return cg;
    }

    static o j(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.ch;
    }

    static Vector bI()
    {
        return ak;
    }

    static boolean d(boolean flag)
    {
        return cn = flag;
    }

    static boolean e(boolean flag)
    {
        return ea = flag;
    }

    static StringBuffer a(StringBuffer stringbuffer)
    {
        return ar = stringbuffer;
    }

    static boolean f(boolean flag)
    {
        return au = flag;
    }

    static int bJ()
    {
        return al;
    }

    static o bK()
    {
        return am;
    }

    static String bL()
    {
        return ap;
    }

    static boolean bM()
    {
        return an;
    }

    static boolean bN()
    {
        return ao;
    }

    static o a(MemoDictMIDlet memodictmidlet, o o1)
    {
        return memodictmidlet.ci = o1;
    }

    static String m(String s1)
    {
        return fg = s1;
    }

    static int B(int i1)
    {
        return fh = -1;
    }

    static boolean g(boolean flag)
    {
        return W = flag;
    }

    static boolean bO()
    {
        return W;
    }

    static boolean h(boolean flag)
    {
        return cg = false;
    }

    static int C(int i1)
    {
        return eU = i1;
    }

    static int D(int i1)
    {
        return dc = i1;
    }

    static int E(int i1)
    {
        return eb = i1;
    }

    static o d(o o1)
    {
        return bT = null;
    }

    static o bP()
    {
        return bV;
    }

    static boolean bQ()
    {
        return aJ;
    }

    static String n(String s1)
    {
        return aL = s1;
    }

    static int F(int i1)
    {
        return bO = i1;
    }

    static o e(o o1)
    {
        return bN = null;
    }

    static ag bR()
    {
        return ag;
    }

    static boolean bS()
    {
        return ai;
    }

    static s a(s s1)
    {
        return ah = null;
    }

    static boolean i(boolean flag)
    {
        return dJ = false;
    }

    static o f(o o1)
    {
        return bR = null;
    }

    static int bT()
    {
        return ed;
    }

    static Vector bU()
    {
        return ec;
    }

    static int G(int i1)
    {
        return ay = 0;
    }

    static boolean bV()
    {
        return aF;
    }

    static int bW()
    {
        return cW;
    }

    static byte bX()
    {
        return cX;
    }

    static void k(MemoDictMIDlet memodictmidlet)
    {
        if((memodictmidlet = memodictmidlet).ce.m())
        {
            int i1 = memodictmidlet.ce.f(0);
            s s1 = memodictmidlet.cd;
            memodictmidlet.cd.r = i1;
            if(!memodictmidlet.k())
            {
                memodictmidlet.ce.p();
                s s2;
                memodictmidlet.ce.a(0, (s2 = memodictmidlet.cd).r, (s2 = memodictmidlet.cd).m);
            }
        } else
        {
            memodictmidlet.ce.h();
        }
        dc = memodictmidlet.ce.f(memodictmidlet.ce.q());
    }

    static void l(MemoDictMIDlet memodictmidlet)
    {
        int i1 = (memodictmidlet = memodictmidlet).ce.q();
        int j1;
        if((j1 = memodictmidlet.ce.f(i1)) + 1 < memodictmidlet.cd.e)
        {
            if(memodictmidlet.ce.n())
            {
                int k1 = j1;
                s s1 = memodictmidlet.cd;
                memodictmidlet.cd.r = k1;
                if(!memodictmidlet.j())
                {
                    memodictmidlet.ce.o();
                    s s2;
                    memodictmidlet.ce.a(i1, (s2 = memodictmidlet.cd).r, (s2 = memodictmidlet.cd).m);
                }
            } else
            {
                memodictmidlet.ce.i();
            }
            dc = memodictmidlet.ce.f(memodictmidlet.ce.q());
        }
    }

    static byte[] bY()
    {
        return dC;
    }

    static int bZ()
    {
        return dV--;
    }

    static int H(int i1)
    {
        return dV = 0;
    }

    static int I(int i1)
    {
        return dW = i1;
    }

    static Vector ca()
    {
        return fj;
    }

    static int cb()
    {
        return cH;
    }

    static int cc()
    {
        return cL;
    }

    static int cd()
    {
        return cP;
    }

    static j m(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.cl;
    }

    static boolean ce()
    {
        return ea;
    }

    static int cf()
    {
        return dG;
    }

    static boolean cg()
    {
        return aG;
    }

    static boolean ch()
    {
        return false;
    }

    static int ci()
    {
        return cs;
    }

    static boolean cj()
    {
        return aB;
    }

    static int ck()
    {
        return fi;
    }

    static byte cl()
    {
        return cR;
    }

    static byte cm()
    {
        return cS;
    }

    static boolean j(boolean flag)
    {
        return aB = flag;
    }

    static byte cn()
    {
        return cV;
    }

    static byte co()
    {
        return cT;
    }

    static int J(int i1)
    {
        return ed = i1;
    }

    static o cp()
    {
        return eq;
    }

    static String o(String s1)
    {
        return bM = s1;
    }

    static int K(int i1)
    {
        return eR = i1;
    }

    static String b(MemoDictMIDlet memodictmidlet, String s1)
    {
        return memodictmidlet.eP = s1;
    }

    static String cq()
    {
        return aR;
    }

    static Vector cr()
    {
        return eg;
    }

    static int cs()
    {
        return cG;
    }

    static o g(o o1)
    {
        return bY = o1;
    }

    static Graphics ct()
    {
        return dl;
    }

    static int cu()
    {
        return dw;
    }

    static int cv()
    {
        return dx;
    }

    static int cw()
    {
        return dy;
    }

    static int cx()
    {
        return dz;
    }

    static int cy()
    {
        return dn;
    }

    static int cz()
    {
        return dd;
    }

    static String cA()
    {
        return be;
    }

    static String cB()
    {
        return bf;
    }

    static o h(o o1)
    {
        return bX = o1;
    }

    static int[] cC()
    {
        return dD;
    }

    static String cD()
    {
        return aV;
    }

    static String cE()
    {
        return aX;
    }

    static int cF()
    {
        return cK;
    }

    static char a(char c1)
    {
        return bx = c1;
    }

    static TextBox cG()
    {
        return bw;
    }

    static int cH()
    {
        return ed--;
    }

    static int cI()
    {
        return ed++;
    }

    static int cJ()
    {
        return cO;
    }

    static Vector cK()
    {
        return em;
    }

    static int L(int i1)
    {
        return bP = 2;
    }

    static int cL()
    {
        return bZ;
    }

    static void a(MemoDictMIDlet memodictmidlet, boolean flag, String s1)
    {
        memodictmidlet.a(flag, s1);
    }

    static int M(int i1)
    {
        return dQ = 0;
    }

    static String cM()
    {
        return fp;
    }

    static int cN()
    {
        return bE;
    }

    static String cO()
    {
        return fq;
    }

    static String cP()
    {
        return ft;
    }

    static String cQ()
    {
        return fs;
    }

    static String p(String s1)
    {
        return fs = s1;
    }

    static String q(String s1)
    {
        return fq = s1;
    }

    static String r(String s1)
    {
        return ft = s1;
    }

    static o i(o o1)
    {
        return bD = o1;
    }

    static String[] cR()
    {
        return fv;
    }

    static int cS()
    {
        return fr;
    }

    static int cT()
    {
        return fu;
    }

    static int cU()
    {
        return cE;
    }

    static void b(MemoDictMIDlet memodictmidlet, int i1)
    {
        ai(i1);
    }

    static int cV()
    {
        return eU;
    }

    static int cW()
    {
        return fa;
    }

    static int cX()
    {
        return eZ;
    }

    static byte cY()
    {
        return cU;
    }

    static boolean[] cZ()
    {
        return eW;
    }

    static void c(MemoDictMIDlet memodictmidlet, int i1)
    {
        memodictmidlet = i1;
        i1 = 0;
        if(cm == 2 || cm == 3 || cm == 4)
            i1 = cj.q();
        int j1 = 0;
        o o1 = null;
        if(cm == 7)
            o1 = bR;
        else
        if(cm == 2 && cF == 4 || cm == 3 && cJ == 4 || cm == 4 && cN == 4)
            o1 = cj;
        if(cm == 3 && cJ == 4 && fj.size() == 1)
        {
            int k1 = o1.n.size();
            v.b(0);
            memodictmidlet += o1.n.size() - k1;
        }
        int l1 = 0;
        int i2 = 0;
        int j2 = 0;
        do
        {
            if(j2 >= fj.size())
                break;
            i2 = (af)(af)fj.elementAt(j2);
            if(l1 + ((af) (i2)).b > memodictmidlet)
            {
                i2 = j2;
                break;
            }
            l1 += ((af) (i2)).b;
            i2 = j2;
            j2++;
        } while(true);
        af af1 = (af)(af)fj.elementAt(i2);
        o1.b(l1, af1.b);
        o1 = 0 + af1.b;
        fj.removeElementAt(i2);
        if((cm == 2 || cm == 3 || cm == 4) && fj.size() > 0)
        {
            if(l1 + o1 < i1)
            {
                cj.i(i1 - o1);
            } else
            {
                if(i1 >= fj.size())
                    i1 = fj.size() - 1;
                cj.i(i1);
            }
            dW = cj.f(cj.q());
        }
    }

    static int N(int i1)
    {
        return er = i1;
    }

    static int da()
    {
        return bp;
    }

    static int db()
    {
        return bq;
    }

    static boolean k(boolean flag)
    {
        return co = false;
    }

    static int dc()
    {
        return dc;
    }

    static void d(MemoDictMIDlet memodictmidlet, int i1)
    {
        memodictmidlet.aj(i1);
    }

    static int dd()
    {
        return ca;
    }

    static Vector de()
    {
        return dR;
    }

    static int df()
    {
        return bJ;
    }

    static o j(o o1)
    {
        return bI = o1;
    }

    static StringBuffer dg()
    {
        return ar;
    }

    static e dh()
    {
        return cp;
    }

    static e a(e e1)
    {
        return cp = e1;
    }

    static int di()
    {
        return ay;
    }

    static char[] dj()
    {
        return fn;
    }

    static int[] n(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.P;
    }

    static String[] o(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.O;
    }

    static int dk()
    {
        return as;
    }

    static boolean dl()
    {
        return au;
    }

    static int dm()
    {
        return at;
    }

    static int O(int i1)
    {
        return at = i1;
    }

    static int P(int i1)
    {
        return as = i1;
    }

    static boolean l(boolean flag)
    {
        return av = flag;
    }

    static Timer p(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.ck;
    }

    static Timer a(MemoDictMIDlet memodictmidlet, Timer timer)
    {
        return memodictmidlet.ck = timer;
    }

    static j a(MemoDictMIDlet memodictmidlet, j j1)
    {
        return memodictmidlet.cl = j1;
    }

    static int dn()
    {
        return ay++;
    }

    static int _mthdo()
    {
        return ay--;
    }

    static int dp()
    {
        return Y;
    }

    static int dq()
    {
        return aa;
    }

    static int Q(int i1)
    {
        return Y -= i1;
    }

    static int R(int i1)
    {
        return Y += i1;
    }

    static int dr()
    {
        return X;
    }

    static int ds()
    {
        return Z;
    }

    static int S(int i1)
    {
        return X -= i1;
    }

    static void q(MemoDictMIDlet memodictmidlet)
    {
        int i1 = (memodictmidlet = memodictmidlet).ce.d();
        int j1;
        if((j1 = memodictmidlet.ce.f(0)) - i1 >= 0)
            memodictmidlet.aj(j1 - i1);
        else
            memodictmidlet.aj(0);
        dc = memodictmidlet.ce.f(memodictmidlet.ce.q());
    }

    static int T(int i1)
    {
        return X += i1;
    }

    static void r(MemoDictMIDlet memodictmidlet)
    {
        int i1 = (memodictmidlet = memodictmidlet).ce.d();
        int j1;
        s s1;
        if((j1 = memodictmidlet.ce.f(0)) + i1 < (s1 = memodictmidlet.cd).e)
            memodictmidlet.aj(j1 + i1);
        dc = memodictmidlet.ce.f(memodictmidlet.ce.q());
    }

    static int dt()
    {
        return az;
    }

    static int du()
    {
        return cw;
    }

    static int dv()
    {
        return cx;
    }

    static int U(int i1)
    {
        return dF = i1;
    }

    static int dw()
    {
        return dF;
    }

    static int dx()
    {
        return dV++;
    }

    static boolean m(boolean flag)
    {
        return V = flag;
    }

    static int V(int i1)
    {
        return al = i1;
    }

    static o k(o o1)
    {
        return am = o1;
    }

    static boolean n(boolean flag)
    {
        return an = flag;
    }

    static boolean o(boolean flag)
    {
        return ao = flag;
    }

    static String s(String s1)
    {
        return ap = s1;
    }

    static int W(int i1)
    {
        return aq = i1;
    }

    static int dy()
    {
        return fm;
    }

    static char[] dz()
    {
        return fk;
    }

    static int dA()
    {
        return fl;
    }

    static int X(int i1)
    {
        return ad = i1;
    }

    static int Y(int i1)
    {
        return ae = i1;
    }

    static boolean p(boolean flag)
    {
        return af = flag;
    }

    static String[] s(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.eM;
    }

    static int[] dB()
    {
        return eN;
    }

    static int Z(int i1)
    {
        return ac = i1;
    }

    static int aa(int i1)
    {
        return ab = i1;
    }

    static int dC()
    {
        return ab;
    }

    static int dD()
    {
        return ac;
    }

    static int dE()
    {
        return ad;
    }

    static int dF()
    {
        return ae;
    }

    static boolean dG()
    {
        return af;
    }

    static int ab(int i1)
    {
        return ae += i1;
    }

    static int ac(int i1)
    {
        return ae -= i1;
    }

    static int dH()
    {
        return de;
    }

    static Font dI()
    {
        return dm;
    }

    static int dJ()
    {
        return dL;
    }

    static boolean dK()
    {
        return co;
    }

    static boolean dL()
    {
        return av;
    }

    static int ad(int i1)
    {
        return eS = i1;
    }

    static int ae(int i1)
    {
        return eT = i1;
    }

    static byte dM()
    {
        return df;
    }

    static boolean dN()
    {
        return aH;
    }

    static int af(int i1)
    {
        return fa = i1;
    }

    static boolean dO()
    {
        return fb;
    }

    static int[] dP()
    {
        return eV;
    }

    static String[] dQ()
    {
        return eX;
    }

    static String[] dR()
    {
        return eY;
    }

    static Random dS()
    {
        return fc;
    }

    static int ag(int i1)
    {
        return eZ = i1;
    }

    static String dT()
    {
        return dO;
    }

    static int dU()
    {
        return dh;
    }

    static int ah(int i1)
    {
        return dh = i1;
    }

    static String dV()
    {
        return dP;
    }

    static boolean dW()
    {
        return V;
    }

    static String t(MemoDictMIDlet memodictmidlet)
    {
        return memodictmidlet.aS;
    }

    static String dX()
    {
        return bM;
    }

    static boolean dY()
    {
        return aw;
    }

    static int dZ()
    {
        return aq;
    }

    public void _c_c()
    {
        MemoDictMIDlet _tmp = this;
        a = -1;
        O = (new String[] {
            "1.- ", "2abc", "3def", "4ghi", "5jkl", "6mno", "7pqrs", "8tuv", "9wxyz"
        });
        P = (new int[] {
            0, 21, 0, 22, 8, -12, -8, -12, 50, 1, 
            56, 2, 52, 3, 54, 4, 53, 5, 55, 6, 
            57, 7, 49, 10, 51, 11, 42, -12, 42, 13, 
            48, -15, 48, 14, 35, 16
        });
        aN = (new String[] {
            "高中", "高中词组", "四级", "四级词组", "六级", "六级词组", "考研", "托福", "雅思", "GRE"
        });
        aO = (new int[] {
            1, 101, 2, 102, 3, 103, 4, 5, 6, 7
        });
        aP = (new String[] {
            "背景色", "前景色", "单词", "音标", "解释", "巧记", "同义词", "反义词", "例句(英)", "例句(中)"
        });
        aQ = "file:///";
        aS = "audio/mpeg";
        aU = false;
        dA = "记忆宝背单词";
        es = (new String[] {
            "词典管理", "查词", "翻译"
        });
        eu = (new String[] {
            "选择词典", "添加词典", "删除词典"
        });
        ew = (new String[] {
            "选择词库", "指定分组", "浏览设置", "统计信息"
        });
        ey = (new String[] {
            "选择复习", "浏览设置"
        });
        eA = (new String[] {
            "选择课件", "添加课件", "删除课件", "排序", "设置"
        });
        eC = (new String[] {
            "目录", "播放", "暂停", "跳转", "复读", "英文", "中文"
        });
        eE = (new String[] {
            "新增 ", "改名", "删除", "上移", "下移", "导入", "导出"
        });
        eG = (new String[] {
            "添加单词", "编辑单词", "删除单词", "上移单词", "下移单词", "浏览设置"
        });
        eI = (new String[] {
            "帮助", "系统信息", "注册", "关于"
        });
        eK = (new String[] {
            "屏幕设置", "键盘设置", "语音设置", "扩展设置", "文件管理"
        });
        eM = (new String[] {
            "0级(未学)", "1级(初学)", "2级(见过)", "3级(模糊)", "4级(认识)", "5级(掌握)"
        });
        eP = "/";
        fe = (new String[] {
            "IMEI", "phone.imei", "device.imei", "com.motorola.imei", "com.nokia.mid.imei", "com.sonyericsson.imei", "com.samsung.imei", "com.siemens.imei", "IMSI"
        });
        cb = Display.getDisplay(this);
        aT = true;
        dY = new Date();
    }

    public void _d_d()
    {
        if(!aT)
            break MISSING_BLOCK_LABEL_1679;
        a = -1;
        T = true;
        U = "正在进行设置,瓜瓜破解分享...";
        g.a(cb);
        if(g.a == 3)
        {
            P[0] = -36;
            P[2] = -37;
        }
        if(g.a == 2)
        {
            aR = "file:///E:/MemoDict/";
            String s1 = System.getProperty("microedition.platform").toLowerCase();
            String as2[] = {
                "e61", "e62", "e63", "e71", "e72", "e73", "6760", "6790", "7705"
            };
            int k1 = 0;
            do
            {
                if(k1 >= as2.length)
                    break;
                String s3 = as2[k1];
                int k2;
                if((k2 = s1.indexOf(s3)) >= 0)
                {
                    if(k2 + s3.length() >= s1.length())
                    {
                        fn = fo;
                        break;
                    }
                    if(!Character.isDigit(s1.charAt(k2 + s3.length())))
                    {
                        fn = fo;
                        break;
                    }
                }
                k1++;
            } while(true);
        } else
        if(g.a == 10)
            aR = "file:///root1/MemoDict/";
        cm = -1;
        ax = null;
        (v = new z(this)).setFullScreenMode(true);
        v.repaint();
        cb.setCurrent(v);
        bg = new Command("确认", 4, 1);
        bh = new Command("取消", 3, 1);
        (bi = new Alert("错误")).setType(AlertType.ERROR);
        bi.setTimeout(3000);
        (bj = new Alert("提示")).setType(AlertType.INFO);
        bj.setTimeout(3000);
        dH = new i(this);
        if(g.b > 0)
            aC = true;
        String as1[];
        if((as1 = Manager.getSupportedProtocols(aS)) != null && as1.length > 0)
            aD = true;
        if((as1 = Manager.getSupportedProtocols("audio/amr")) != null && as1.length > 0)
            aE = true;
        if(aC)
            aG = true;
        if(aC)
            aF = true;
        if(!aG)
            eL[2] = 0;
        if(!aF)
            eL[3] = 0;
        if(!aC)
        {
            eL[4] = 0;
            eF[5] = 0;
            eF[6] = 0;
        }
        if(v.hasPointerEvents())
            aH = true;
        m = false;
        Object obj;
        try
        {
            if(((String) (obj = new String(fw, "GBK"))).equals("记忆宝"))
                m = true;
        }
        catch(Exception exception1) { }
        for(int j1 = 0; j1 < fe.length && ((ff = System.getProperty(fe[j1])) == null || ff.length() < 15); j1++);
        if(ff == null)
            ff = "";
        cc = new s("res:/dict/dat0");
        cd = cc;
        dC = new byte[cc.e];
        dB = new byte[cc.e << 1];
        j1 = getClass().getResourceAsStream("/dict/idlist");
        try
        {
            j1.read(dB);
            j1.close();
        }
        catch(Exception exception2)
        {
            a("rl", exception2);
        }
        ec = new Vector();
        eg = new Vector();
        em = new Vector();
        bO = 0;
        eb();
        cC = 0;
        cD = 0;
        da = 1;
        cF = 0;
        cG = 2;
        cH = 0;
        cI = 0;
        cJ = 0;
        cK = 2;
        cL = 0;
        cM = 0;
        cN = 0;
        cO = 2;
        cP = 0;
        cQ = 0;
        df = 1;
        dg = 0;
        MemoDictMIDlet memodictmidlet = this;
        try
        {
            memodictmidlet.bk = RecordStore.openRecordStore("MemoStore", true);
        }
        catch(RecordStoreException _ex)
        {
            memodictmidlet.bk = null;
        }
        if(bk == null)
        {
            U = U + "\n错误: 不能打开数据库!";
            v.repaint();
            v.serviceRepaints();
            try
            {
                Thread.sleep(5000L);
            }
            catch(Exception _ex) { }
            a = 1;
            destroyApp(false);
            notifyDestroyed();
            return;
        }
        try
        {
            ee();
            MemoDictMIDlet memodictmidlet1;
            if((memodictmidlet1 = this).bk != null)
            {
                try
                {
                    byte abyte1[] = memodictmidlet1.bk.getRecord(2);
                    memodictmidlet1.a(cu, abyte1);
                }
                catch(RecordStoreException _ex) { }
                byte abyte0[];
                if(cu == 0)
                    dQ = 0;
                else
                    try
                    {
                        a(abyte0 = memodictmidlet1.bk.getRecord(3), false);
                    }
                    catch(Exception _ex)
                    {
                        dQ = 0;
                    }
            }
            Date date;
            int i2 = (int)((date = new Date()).getTime() / 0x5265c00L) - 14092;
            if(cu < 2 || aU)
            {
                ec.addElement(new w("重点词"));
                ec.addElement(new w("生词本"));
            }
            if(eg.size() == 0)
            {
                eg.addElement(new ai("记忆宝英语词典", ""));
                bL = 0;
                dc = 0;
            }
            if(cu < 3 || aK.length() != 12 || aU)
            {
                if(ff.length() > 8)
                {
                    aK = u(ff);
                } else
                {
                    int l2 = fc.nextInt() & 0xffff;
                    int k3 = (i2 ^ 0x3721 ^ l2) & 0xffff;
                    aK = a(l2, 5) + a(k3, 5);
                }
                int i3 = 0;
                for(int i4 = 0; i4 < aK.length(); i4++)
                {
                    char c1 = aK.charAt(i4);
                    i3 += c1;
                }

                i3 %= 10;
                aK = i3 + "0" + aK;
            } else
            if(aL.length() + 300 == 315)
                try
                {
                    int j3 = Integer.parseInt(aL.substring(0, 5));
                    int j4 = Integer.parseInt(aL.substring(5, 10));
                    int k4 = Integer.parseInt(aL.substring(10, 15));
                    int i5 = Integer.parseInt(aK.substring(2, 7));
                    int i1 = 13463;
                    String s2 = n.toLowerCase();
                    for(int l1 = 0; l1 < s2.length(); l1++)
                    {
                        int j2 = s2.charAt(l1);
                        if(l1 % 2 == 1)
                            j2 = (j2 & 0xff) << 7 | j2 >> 6;
                        i1 = i1 ^ l1 ^ j2;
                    }

                    i1 &= 0xffff;
                    if((i5 ^ 0xe6b3 ^ j4) == j3 && i1 == (k4 ^ j4))
                        aJ = true;
                    if((i5 ^ 0xe6b3 ^ j4) == j3 && i1 == (k4 ^ j4))
                        o = n.toLowerCase();
                }
                catch(Exception _ex) { }
            o();
            cy = p();
            if(cB >= dG)
                cB = 0;
            db = cy[cB];
            eg();
            if(g.d && cY != 0)
                g.a(l);
            long l4;
            for(long l3 = System.currentTimeMillis(); !v.isShown() && (l4 = System.currentTimeMillis()) - l3 <= 1000L;);
            System.gc();
            ea();
            cm = 0;
            f = bF;
            v.e();
            T = false;
            v.repaint();
            cb.setCurrent(v);
            if(ct < 15)
                aM = ff;
            else
            if(ff.compareTo(aM) != 0)
            {
                a("提示", "手机验证信息不对,请重新安装软件", 0);
                aJ = false;
            }
            bT = null;
            aT = false;
            return;
        }
        catch(Exception exception)
        {
            a("初始化错误:", exception);
        }
        v.repaint();
        v.serviceRepaints();
        try
        {
            Thread.sleep(5000L);
        }
        catch(Exception _ex) { }
        bk = null;
        a = 2;
        destroyApp(false);
        notifyDestroyed();
    }

    public void _a_a()
    {
        _c_c();
    }

    public void _b_b()
    {
        _d_d();
    }

    int a;
    private final String O[];
    private final int P[];
    public static boolean b = false;
    public static boolean c = false;
    private static boolean Q = false;
    public static String d = "";
    private static a R = null;
    public static a e = null;
    private static g S = new g();
    private static boolean T;
    private static String U;
    private static boolean V = false;
    private static boolean W = false;
    private static int X;
    private static int Y;
    private static int Z;
    private static int aa;
    private static int ab;
    private static int ac;
    private static int ad;
    private static int ae;
    private static boolean af;
    private static ag ag;
    private static s ah;
    private static boolean ai;
    private static int aj = 0;
    private static Vector ak = new Vector();
    private static int al = 0;
    private static o am = null;
    private static boolean an = false;
    private static boolean ao;
    private static String ap;
    private static int aq;
    private static StringBuffer ar;
    private static int as = -1;
    private static int at = -1;
    private static boolean au = false;
    private static boolean av = true;
    private static boolean aw = false;
    public static o f = null;
    private static o ax;
    private static int ay = 0;
    public static int g = 0;
    public static byte h = 0;
    public static byte i = 0;
    public static byte j = 0;
    public static int k = 100;
    private static int az;
    public static byte l = 100;
    private static int aA;
    private static boolean aB = false;
    private static boolean aC = false;
    private static boolean aD = false;
    private static boolean aE = false;
    private static boolean aF = false;
    private static boolean aG = false;
    private static boolean aH = false;
    public static boolean m = false;
    private static byte aI = 0;
    private static boolean aJ = true;
    public static String n = "";
    private static String aK = "";
    private static String aL = "";
    private static String aM = "";
    private final String aN[];
    private final int aO[];
    private final String aP[];
    private String aQ;
    private static String aR = "file:///b/MemoDict/";
    private String aS;
    private boolean aT;
    private boolean aU;
    private static String aV = "菜单";
    private static String aW = "确认";
    private static String aX = "返回";
    private static String aY = "取消";
    private static String aZ = "添加";
    private static String ba = "开始";
    private static String bb = "退出";
    private static String bc = "是";
    private static String bd = "否";
    private static String be;
    private static String bf;
    static String o = "";
    private static Command bg;
    private static Command bh;
    private static Alert bi;
    private static Alert bj;
    private RecordStore bk;
    private static int bl;
    private static int bm;
    private static int bn;
    private static int bo;
    private static int bp;
    private static int bq;
    private static int br;
    private static int bs;
    private static int bt;
    private static int bu;
    private static int bv;
    private static TextBox bw;
    private static char bx = ' ';
    private static int by;
    private static int bz;
    private static int bA;
    private static int bB;
    private static o bC;
    public static o p;
    private static o bD;
    private static int bE;
    private static o bF;
    private static int bG;
    private static int bH;
    private static o bI;
    private static int bJ;
    public static int q[] = {
        0xffffff, 0, 0, 0, 0, 119, 0x7777cc, 170, 0, 0xaa0000, 
        0x9c9955, 0x6b6700, 26475, 170
    };
    public static int r[] = {
        25153, 0xc9e4d6, 0, 0, 0, 0xc9e4d6, 0x67bf7f, 0x67bf7f, 0, 0x67bf7f, 
        0xd0770b, 0xface9c, 0xc9e4d6, 0x67bf7f
    };
    public static int s[] = {
        0, 0x808080, 0, 0, 0, 0xffffff, 0x808080, 0xc0c0c0, 0, 0xffff80, 
        0xdcd800, 0xf1af00, 0xc0c0c0, 0x808080
    };
    public static int t[] = {
        16512, 0xc0c0c0, 0, 0, 0, 65280, 32896, 0x80ffff, 0, 65535, 
        0xffff00, 0x808000, 65280, 0x80ffff
    };
    static final int u[] = {
        0, 0x808080, 0xc0c0c0, 0xffffff, 0x800000, 0xff0000, 0x808000, 0xffff00, 32768, 65280, 
        32896, 65535, 128, 255, 0x800080, 0xff00ff, 0x808040, 0xffff80, 16448, 65408, 
        33023, 0x80ffff, 16512, 0x8080ff, 0x8000ff, 0xff0080, 0x804000, 0xff8040
    };
    private static o bK;
    private static int bL = 0;
    private static String bM;
    private static o bN;
    private static int bO;
    private static int bP;
    private static o bQ;
    private static o bR;
    private static o bS;
    private static o bT;
    private static o bU;
    private static o bV;
    private static o bW;
    private static o bX;
    private static o bY;
    public static z v;
    private static int bZ;
    private static int ca;
    private static Display cb;
    private s cc;
    private s cd;
    private o ce;
    private o cf;
    private static boolean cg;
    private o ch;
    private o ci;
    private static o cj;
    private Timer ck;
    private j cl;
    private static int cm;
    private static boolean cn;
    private static boolean co;
    private static e cp;
    private static String cq;
    public static int w;
    public static int x;
    public static String y;
    public static int z;
    private static boolean cr;
    private static int cs;
    private static int ct;
    private static int cu;
    private static int cv;
    private static int cw;
    private static int cx;
    private static short cy[];
    private static int cz;
    private static int cA;
    private static int cB;
    private static byte cC;
    private static int cD;
    private static int cE = 0;
    private static int cF = 0;
    private static int cG = 2;
    private static int cH = 0;
    private static byte cI;
    private static int cJ = 0;
    private static int cK = 2;
    private static int cL = 0;
    private static byte cM;
    private static int cN;
    private static int cO;
    private static int cP;
    private static byte cQ;
    public static byte A = 1;
    private static byte cR = 1;
    private static byte cS = 1;
    private static byte cT = 0;
    private static byte cU = 0;
    private static byte cV = 1;
    private static int cW = 1;
    private static byte cX = 1;
    private static int cY;
    private static byte cZ = 0;
    private static byte da;
    private static int db = 0;
    private static int dc = 0;
    private static int dd = 0;
    private static int de = 0;
    private static byte df;
    private static byte dg;
    private static int dh;
    public static int B[];
    private static Image di;
    public static Image C[] = new Image[14];
    public static Image D;
    public static Image E;
    private static int dj;
    private static int dk;
    private static Graphics dl;
    private static Font dm;
    private static int dn;
    public static int F;
    private static int _flddo;
    private static int dp;
    private static int dq;
    private static int dr;
    private static int ds;
    private static int dt;
    private static int du;
    private static int dv;
    private static int dw;
    private static int dx;
    private static int dy;
    private static int dz;
    private String dA;
    private static byte dB[];
    private static byte dC[];
    private static int dD[] = new int[6];
    private static int dE[] = new int[6];
    private static int dF;
    private static int dG;
    private i dH;
    private static n dI = new n();
    private static boolean dJ = false;
    private static int dK = -1;
    private static int dL;
    private static int dM = 0;
    private static int dN = -1;
    private static String dO = "";
    private static String dP = "";
    public static int G;
    private static int dQ;
    private static Vector dR = new Vector();
    private static boolean dS[] = new boolean[16];
    private static boolean dT[] = new boolean[6];
    private static int dU[] = new int[16];
    private static int dV;
    private static int dW;
    private static int dX[] = {
        0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 
        0, 0, 0, 0, 0, 1
    };
    private Date dY;
    private Date dZ;
    private static boolean ea = false;
    private static int eb;
    private static Vector ec;
    private static int ed = 0;
    private static o ee;
    private static o ef;
    private static Vector eg;
    private static o eh;
    private static o ei;
    private static o ej;
    private static o ek;
    private static o el;
    private static Vector em;
    private static o en;
    private static o eo;
    private static o ep;
    private static o eq = null;
    private static int er;
    private final String es[];
    private static int et[] = {
        3, 1, 0
    };
    private final String eu[];
    private static int ev[] = {
        1, 2, 3
    };
    private final String ew[];
    private static int ex[] = {
        1, 2, 3, 4
    };
    private final String ey[];
    private static int ez[] = {
        1, 2
    };
    private final String eA[];
    private static int eB[] = {
        1, 2, 3, 4, 0
    };
    private final String eC[];
    private static int eD[] = {
        1, 2, 3, 5, 6, 7, 8
    };
    private final String eE[];
    private static int eF[] = {
        1, 2, 3, 0, 0, 6, 7
    };
    private final String eG[];
    private static int eH[] = {
        1, 2, 3, 4, 5, 6
    };
    private final String eI[];
    private static int eJ[] = {
        1, 2, 3, 4
    };
    private final String eK[];
    private static int eL[] = {
        1, 0, 3, 4, 5
    };
    private final String eM[];
    private static int eN[] = {
        1, 2, 3, 4, 5, 6
    };
    private static boolean eO = false;
    private String eP;
    private static o eQ;
    private static int eR;
    private static int eS;
    private static int eT;
    private static int eU = -1;
    public static boolean H;
    private static int eV[] = new int[4];
    private static boolean eW[] = new boolean[4];
    private static String eX[] = new String[4];
    private static String eY[] = new String[4];
    private static int eZ;
    private static int fa;
    private static boolean fb;
    private static Random fc = new Random();
    private static String fd[] = {
        "audio/midi", "audio/x-wav", "audio/amr", "audio/mpeg", "audio/mp4", "video/3gpp", "video/mpeg", "video/mp4"
    };
    private final String fe[];
    private static String ff = null;
    private static String fg = "";
    private static int fh = -1;
    private static int fi;
    private static Vector fj;
    int I[];
    private static char fk[] = {
        'q', '\002', 'w', '\002', 'e', '\002', 'r', '\002', 't', '\002', 
        'y', '\002', 'u', '\002', 'i', '\002', 'o', '\002', 'p', '\002', 
        '<', '\003', '\n', '\002', '\0', '\001', 'a', '\002', 's', '\002', 
        'd', '\002', 'f', '\002', 'g', '\002', 'h', '\002', 'j', '\002', 
        'k', '\002', 'l', '\002', '-', '\002', '\'', '\002', '\n', '\002', 
        '\0', '\002', 'z', '\002', 'x', '\002', 'c', '\002', 'v', '\002', 
        'b', '\002', 'n', '\002', 'm', '\002', ',', '\002', '.', '\002', 
        ' ', '\003'
    };
    private static int fl;
    private static int fm;
    private static char fn[] = null;
    private static char fo[] = {
        'r', '1', 't', '2', 'y', '3', 'u', '*', 'f', '4', 
        'g', '5', 'h', '6', 'j', '#', 'v', '7', 'b', '8', 
        'n', '9', 'm', '0'
    };
    static int J = 0;
    static int K = 0;
    private static String fp = "http://www.jiyibao.com/trans/trans.php";
    private static String fq = "en";
    private static int fr = -1;
    private static String fs = "I am a programmer.";
    private static String ft = "zh-CN";
    private static int fu = -1;
    public static String L = "";
    private static String fv[] = {
        "en", "英语", "zh-CN", "中文(简体)", "zh-TW", "中文(繁体)", "sq", "阿尔巴尼亚文", "ar", "阿拉伯文", 
        "ga", "爱尔兰文", "et", "爱沙尼亚语", "be", "白俄罗斯语", "bg", "保加利亚文", "is", "冰岛语", 
        "pl", "波兰语", "fa", "波斯语", "af", "布尔文(南非洲的荷兰文)", "ko", "朝鲜语", "da", "丹麦语", 
        "de", "德语", "ru", "俄语", "fr", "法语", "sw", "非洲的斯瓦希里文", "tl", "菲律宾文", 
        "fi", "芬兰语", "nl", "荷兰语", "gl", "加利西亚语", "ca", "加泰罗尼亚语", "cs", "捷克语", 
        "hr", "克罗地亚文", "lv", "拉脱维亚语", "lt", "立陶宛语", "ro", "罗马尼亚语", "mt", "马耳他文", 
        "ms", "马来文", "mk", "马其顿文", "no", "挪威语", "pt", "葡萄牙语", "ja", "日语", 
        "sv", "瑞典语", "sr", "塞尔维亚文", "sk", "斯洛伐克文", "sl", "斯洛文尼亚文", "th", "泰文", 
        "tr", "土耳其文", "cy", "威尔士语", "uk", "乌克兰文", "es", "西班牙语", "iw", "希伯来语", 
        "el", "希腊语", "hu", "匈牙利语", "it", "意大利语", "yi", "意第绪语", "hi", "印度文", 
        "id", "印尼文", "vi", "越南文"
    };
    private static byte fw[] = {
        -68, -57, -46, -28, -79, -90
    };
    public static byte M[] = null;
    public static int N = 0;
    public static int _D_D = 0;

}
