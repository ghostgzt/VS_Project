 

import java.util.Random;
import javax.microedition.lcdui.Graphics;

public final class j
{

    public j(v v1, int i1, int ai[], int ai1[], int ai2[])
    {
        a_int_fld = 0;
        f_int_array1d_fld = new int[4];
        d_int_array2d_fld = new int[3][2];
        a_boolean_fld = false;
        l_boolean_fld = false;
        c_int_array2d_fld = new int[6][4];
        a_int_array1d_fld = null;
        f_int_array2d_fld = new int[6][4];
        b_int_array1d_fld = new int[5];
        o_boolean_fld = false;
        a_short_array1d_fld = new short[4];
        j_int_array2d_fld = new int[30][];
        d_int_array1d_fld = new int[5];
        p_int_array1d_fld = new int[2];
        a_v_fld = v1;
        e_int_fld = i1;
        p_int_fld = ai2[8];
        if(b_int_array2d_static_fld == null)
            b_int_array2d_static_fld = c.a(7, 0, 0, -v.x);
        i_int_array2d_fld = new int[ai1.length][2];
        for(v1 = 0; v1 < i_int_array2d_fld.length; v1++)
            i_int_array2d_fld[v1][0] = ai1[v1] * 100;

        a_ad_array1d_fld = new ad[100];
        a_ad_array1d_fld[0] = new b(this, b_int_array2d_static_fld[6]);
        a_ad_array1d_fld[1] = new y(1, this, 0, ai2[7]);
        v1 = -1;
        if(v.d[0] == 1)
            v1 = 6;
        else
        if(v.d[1] == 1)
            v1 = 7;
        a_ad_array1d_fld[2] = new f(2, this, b_int_array2d_static_fld[7], v1);
        a_ad_array1d_fld[3] = new y(3, this, 2, ai2[6]);
        v1 = -1;
        if(v.d[2] == 1)
            v1 = 6;
        else
        if(v.d[3] == 1)
            v1 = 7;
        a_ad_array1d_fld[4] = new a(4, this, b_int_array2d_static_fld[8], v1);
        a_ad_array1d_fld[5] = new y(5, this, 4, ai2[9]);
        a_ad_array1d_fld[6] = new p(6, this, b_int_array2d_static_fld[12]);
        a_ad_array1d_fld[7] = new e(7, this);
        c_int_array1d_fld = (new int[] {
            ((ad) ((p)a_ad_array1d_fld[6])).f, ((ad) ((p)a_ad_array1d_fld[6])).g, ((ad) ((p)a_ad_array1d_fld[6])).h, ((ad) ((p)a_ad_array1d_fld[6])).i
        });
        v1 = 8;
        o_int_array1d_fld = new int[6];
        i1 = 0;
        n_int_array1d_fld = new int[6];
        for(ai1 = 0; ai1 < 6; ai1++)
            if(ai[ai1] != -1)
            {
                a_ad_array1d_fld[v1] = new g(v1, this, ai1, ai[ai1]);
                o_int_array1d_fld[i1] = v1;
                n_int_array1d_fld[i1] = ai1;
                i1++;
                v1++;
                int j1 = ai[ai1] / 10;
                j1 = ai[ai1] - j1 * 10;
                a_ad_array1d_fld[v1] = new y(v1, this, v1 - 1, ai2[j1]);
                v1++;
            }

        m_int_fld = c();
        for(ai1 = 0; ai1 < 5; ai1++)
        {
            if(ai[ai1 + 6] == 0)
                continue;
            for(int k1 = 0; k1 < ai[ai1 + 6]; k1++)
                a(ai1);

        }

        g_int_fld = ai[11];
        n_int_fld = (ai[19] + 30) * 1000;
        o_int_fld = (ai[21] + 60) * 1000;
        l_int_array1d_fld = (new int[] {
            ai[18], ai[20], ai[22]
        });
        m_int_array1d_fld = new int[14];
        ai1 = new int[4][2];
        v1 = 0;
        for(int l1 = 0; l1 < 4 && ai[23 + (l1 << 1)] != -1; l1++)
        {
            ai1[v1][0] = ai[23 + (l1 << 1)];
            ai1[v1][1] = ai[23 + (l1 << 1) + 1];
            v1++;
        }

        h_int_array2d_fld = new int[v1][6];
        for(int i2 = 0; i2 < v1; i2++)
        {
            h_int_array2d_fld[i2][0] = ai1[i2][0];
            h_int_array2d_fld[i2][1] = ai1[i2][1];
            h_int_array2d_fld[i2][4] = -30 - i2 * 15;
            h_int_array2d_fld[i2][5] = h_int_array2d_fld[i2][4];
        }

        g_boolean_fld = false;
        h_boolean_fld = true;
        i_boolean_fld = false;
        n_boolean_fld = false;
        f_int_fld = -1;
        j_boolean_fld = false;
        p_boolean_fld = false;
        d_boolean_fld = false;
        q = false;
        m_boolean_fld = false;
        e();
        a(true);
    }

    public j(v v1, byte abyte0[])
    {
        a_int_fld = 0;
        f_int_array1d_fld = new int[4];
        d_int_array2d_fld = new int[3][2];
        a_boolean_fld = false;
        l_boolean_fld = false;
        c_int_array2d_fld = new int[6][4];
        a_int_array1d_fld = null;
        f_int_array2d_fld = new int[6][4];
        b_int_array1d_fld = new int[5];
        o_boolean_fld = false;
        a_short_array1d_fld = new short[4];
        j_int_array2d_fld = new int[30][];
        d_int_array1d_fld = new int[5];
        p_int_array1d_fld = new int[2];
        a_v_fld = v1;
        v1 = new i(abyte0);
        e_int_fld = v1.a();
        m_int_fld = v1.a();
        p_int_fld = v1.a();
        g_int_fld = v1.b();
        n_int_fld = v1.b();
        o_int_fld = v1.b();
        f_int_fld = v1.a();
        g_boolean_fld = v1.a();
        j_boolean_fld = v1.a();
        p_boolean_fld = v1.a();
        n_boolean_fld = v1.a();
        abyte0 = v1.a();
        h_int_array2d_fld = new int[abyte0][6];
        for(int i1 = 0; i1 < abyte0; i1++)
            h_int_array2d_fld[i1] = v1.a();

        a_long_fld = v1.a();
        d_long_fld = v1.a();
        abyte0 = v1.a();
        i_int_array2d_fld = new int[abyte0][2];
        for(int j1 = 0; j1 < abyte0; j1++)
            i_int_array2d_fld[j1] = v1.a();

        l_int_array1d_fld = v1.a();
        m_int_array1d_fld = v1.a();
        n_int_array1d_fld = v1.a();
        c_int_array1d_fld = v1.a();
        a_short_array1d_fld = v1.a();
        b_int_array2d_static_fld = new int[abyte0 = v1.a()][];
        for(int k1 = 0; k1 < abyte0; k1++)
            b_int_array2d_static_fld[k1] = v1.a();

        abyte0 = v1.a();
        j_int_array2d_fld = new int[30][];
        for(int l1 = 0; l1 < abyte0; l1++)
            j_int_array2d_fld[l1] = v1.a();

        o_int_array1d_fld = v1.a();
        a_ad_array1d_fld = new ad[100];
        abyte0 = v1.a();
        for(int i2 = 0; i2 < abyte0; i2++)
        {
            byte abyte1[];
            if((abyte1 = v1.b()) == null)
                continue;
            if(abyte1[11] == 0)
            {
                a_ad_array1d_fld[abyte1[0]] = new g(this, abyte1);
                continue;
            }
            if(abyte1[11] == 1)
            {
                a_ad_array1d_fld[abyte1[0]] = new l(this, abyte1);
                continue;
            }
            if(abyte1[11] == 2)
            {
                a_ad_array1d_fld[abyte1[0]] = new z(this, abyte1);
                continue;
            }
            if(abyte1[11] == 3)
            {
                a_ad_array1d_fld[abyte1[0]] = new b(this, abyte1);
                continue;
            }
            if(abyte1[11] == 4)
            {
                a_ad_array1d_fld[abyte1[0]] = new y(this, abyte1);
                continue;
            }
            if(abyte1[11] == 5)
            {
                a_ad_array1d_fld[abyte1[0]] = new f(this, abyte1);
                continue;
            }
            if(abyte1[11] == 6)
            {
                a_ad_array1d_fld[abyte1[0]] = new a(this, abyte1);
                continue;
            }
            if(abyte1[11] == 7)
            {
                a_ad_array1d_fld[abyte1[0]] = new p(this, abyte1);
                continue;
            }
            if(abyte1[11] == 8)
            {
                a_ad_array1d_fld[abyte1[0]] = new e(this, abyte1);
                continue;
            }
            if(abyte1[11] == 9)
                a_ad_array1d_fld[abyte1[0]] = new ab(this, abyte1);
        }

        h_boolean_fld = false;
        i_boolean_fld = false;
        g_boolean_fld = false;
        e();
        v.a(4 + v.s, true);
        a(false);
    }

    private void e()
    {
        l_boolean_fld = false;
        int i1 = 0;
        int j1 = 0;
        int k1 = 0;
        for(int l1 = 0; l1 < 6; l1++)
        {
            if(l1 < 3)
            {
                int ai[][] = c.a(g_int_array1d_static_fld[l1], 31, 0, 0);
                d_int_array2d_fld[i1][0] = ai[0][0];
                d_int_array2d_fld[i1][1] = ai[0][1];
                i1++;
            }
            int ai1[][] = c.a(g_int_array1d_static_fld[l1], 0, 0, 0);
            c_int_array2d_fld[j1][0] = ai1[0][0];
            c_int_array2d_fld[j1][1] = ai1[0][1];
            j1++;
            byte byte0 = 18;
            if(l1 < 3)
                byte0 = 32;
            byte0 = c.a(g_int_array1d_static_fld[l1], byte0, 0, 0);
            f_int_array2d_fld[k1][0] = byte0[0][0];
            f_int_array2d_fld[k1][1] = byte0[0][1];
            k1++;
        }

        b_boolean_fld = false;
        c_boolean_fld = true;
        h_int_fld = 0;
        j_int_fld = -1;
        c_int_fld = -1;
        d_int_fld = -1;
        c_long_fld = 0L;
        int ai2[] = new int[4];
        ai2[0] = u.h - 20;
        ai2[1] = u.i - 20;
        ai2[2] = 20;
        ai2[3] = 30;
        k_int_fld = 0;
        e_boolean_fld = false;
        l_int_fld = 14;
        k_int_array1d_fld = (new int[] {
            0, 1
        });
        f_boolean_fld = false;
        if(v.a_int_array2d_static_fld == null)
        {
            v.a_int_array2d_static_fld = c.a(42, 0, 0, -v.x);
            if(u.i < 320)
                v.a_int_array2d_static_fld[16][1] = (u.i >> 1) - 6;
            v.a_int_array2d_static_fld[6][0] = 48;
            v.a_int_array2d_static_fld[6][1] += v.x + (u.i - (u.i <= 300 ? '\u0122' : 320) - 10);
            v.a_int_array2d_static_fld[31][0] = v.a_int_array2d_static_fld[5][0];
            v.a_int_array2d_static_fld[31][1] = v.a_int_array2d_static_fld[5][1];
        }
        v.a_int_array2d_static_fld[2][1] = 15;
        v.a_int_array2d_static_fld[4][1] = 15;
        int i2 = (u.i - 260 >> 1) + 76;
        v.a_int_array2d_static_fld[9][1] = i2;
        v.a_int_array2d_static_fld[10][1] = i2;
        g_int_array2d_fld = c.a(50, 0, 0, -v.x);
        d(0);
        b_int_array1d_fld = a_int_array2d_fld[0];
    }

    private int c()
    {
        int i1 = a_ad_array1d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
            if(a_ad_array1d_fld[j1] == null)
                return j1;

        return -1;
    }

    public final int a()
    {
        int i1 = a_ad_array1d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
            if(a_ad_array1d_fld[j1] != null && (a_ad_array1d_fld[j1] instanceof z) && ((b)a_ad_array1d_fld[0]).c(((z)a_ad_array1d_fld[j1]).a_int_fld) && !((z)a_ad_array1d_fld[j1]).a_boolean_fld)
            {
                ((z)a_ad_array1d_fld[j1]).a_boolean_fld = true;
                return j1;
            }

        return -1;
    }

    public final int[] a(int i1)
    {
        if(a_ad_array1d_fld[i1] instanceof g)
        {
            i1 = (g)a_ad_array1d_fld[i1];
            return (new int[] {
                ((g) (i1)).b, ((g) (i1)).c, ((g) (i1)).a_int_array1d_fld[3] + ((ad) (i1)).f, ((g) (i1)).a_int_array1d_fld[4] + ((ad) (i1)).g, ((g) (i1)).a_int_array1d_fld[5] + ((ad) (i1)).f, ((g) (i1)).a_int_array1d_fld[6] + ((ad) (i1)).g
            });
        }
        if(a_ad_array1d_fld[i1] instanceof f)
        {
            i1 = (f)a_ad_array1d_fld[i1];
            return (new int[] {
                6, ((f) (i1)).b, ((ad) (i1)).f + -8, ((ad) (i1)).g + 30, ((ad) (i1)).f + -10, ((ad) (i1)).g + 50
            });
        }
        if(a_ad_array1d_fld[i1] instanceof b)
        {
            i1 = (b)a_ad_array1d_fld[i1];
            return (new int[] {
                7, ((b) (i1)).b, ((ad) (i1)).f + 81, ((ad) (i1)).g + -5, ((ad) (i1)).f + 115, ((ad) (i1)).g + 65
            });
        }
        if(a_ad_array1d_fld[i1] instanceof a)
        {
            i1 = (a)a_ad_array1d_fld[i1];
            return (new int[] {
                8, ((a) (i1)).b_int_fld, ((ad) (i1)).f + 3, ((ad) (i1)).g + 19, ((ad) (i1)).f + -25, ((ad) (i1)).g + 74
            });
        } else
        {
            return null;
        }
    }

    public final boolean a(int i1)
    {
        int j1;
        if((j1 = c()) != -1)
        {
            if(i1 <= 2)
                a_ad_array1d_fld[j1] = new l(j1, this, i1);
            else
                a_ad_array1d_fld[j1] = new ab(j1, this, i1, p_int_fld);
            return true;
        } else
        {
            return false;
        }
    }

    public final void a(int i1, int j1, int k1)
    {
        int l1;
        if((l1 = c()) != -1)
            a_ad_array1d_fld[l1] = new z(this, l1, i1, new int[] {
                j1, k1
            });
    }

    private int[] b()
    {
        int i1 = 0;
        int ai[] = new int[a_ad_array1d_fld.length - 8];
        for(int j1 = 8; j1 < a_ad_array1d_fld.length; j1++)
            if(a_ad_array1d_fld[j1] != null)
                ai[i1++] = j1;

        for(int k1 = 0; k1 < i1; k1++)
        {
            for(int l1 = 0; l1 < i1; l1++)
            {
                int j2 = a_ad_array1d_fld[ai[k1]].g;
                int l2 = a_ad_array1d_fld[ai[l1]].g;
                if(a_ad_array1d_fld[ai[k1]] instanceof z)
                    j2 -= 60;
                if(a_ad_array1d_fld[ai[l1]] instanceof z)
                    l2 -= 60;
                if(j2 < l2)
                {
                    int k2 = ai[k1];
                    ai[k1] = ai[l1];
                    ai[l1] = k2;
                }
            }

        }

        int ai1[] = new int[i1];
        for(int i2 = 0; i2 < i1; i2++)
            ai1[i2] = ai[i2];

        return ai1;
    }

    public final void a()
    {
        v.a(4 + v.s, true);
        h_boolean_fld = false;
        for(int i1 = 0; i1 < h_int_array2d_fld.length; i1++)
            h_int_array2d_fld[i1][5] = 22;

        a(false);
    }

    private boolean a(ad ad1)
    {
        if(ad1 == null || !(ad1 instanceof ab))
            return false;
        return ((ab)ad1).a == 5 && ((ab)ad1).c == 0 && ((ab)ad1).d >= 1 && ((b)a_ad_array1d_fld[0]).c(9);
    }

    public final void a(int i1)
    {
        int ai[][] = new int[20][2];
        int j1 = 0;
        for(int k1 = 0; k1 < a_ad_array1d_fld.length; k1++)
        {
            if(a_ad_array1d_fld[k1] == null || !(a_ad_array1d_fld[k1] instanceof z) || !((b)a_ad_array1d_fld[0]).c(((z)a_ad_array1d_fld[k1]).a_int_fld))
                continue;
            ai[j1][0] = k1;
            ai[j1][1] = 0;
            if(++j1 >= ai.length)
                break;
        }

        if(j1 < ai.length)
        {
            for(int l1 = 0; l1 < a_ad_array1d_fld.length; l1++)
            {
                if(a_ad_array1d_fld[l1] == null || !a(a_ad_array1d_fld[l1]))
                    continue;
                ai[j1][0] = l1;
                ai[j1][1] = 1;
                if(++j1 >= ai.length)
                    break;
            }

        }
        for(int i2 = 0; i2 < i1; i2++)
        {
            if(i2 >= j1)
                return;
            if(ai[i2][1] == 0)
            {
                b(ai[i2][0]);
                p_boolean_fld = true;
                continue;
            }
            int k2 = ai[i2][0];
            j j2 = this;
            if(a_ad_array1d_fld[k2] != null && ((b)j2.a_ad_array1d_fld[0]).b(9))
            {
                j2.a(new int[] {
                    1, 9, j2.a_ad_array1d_fld[k2].f + j2.a_ad_array1d_fld[6].f, j2.a_ad_array1d_fld[k2].g + j2.a_ad_array1d_fld[6].g
                });
                j2.m_int_array1d_fld[9]++;
                j2.g(k2);
                j2.a_ad_array1d_fld[k2] = null;
            }
        }

    }

    public final void b(int i1)
    {
        int j1 = ((z)a_ad_array1d_fld[i1]).a_int_fld;
        if(a_ad_array1d_fld[i1] != null && ((b)a_ad_array1d_fld[0]).b(j1))
        {
            a(new int[] {
                1, j1, a_ad_array1d_fld[i1].f, a_ad_array1d_fld[i1].g
            });
            m_int_array1d_fld[j1]++;
            v.b[0]++;
            a_ad_array1d_fld[i1] = null;
        }
    }

    public final void a(int i1, int j1)
    {
        ((p)a_ad_array1d_fld[6]).a(i1, j1);
    }

    private void b(Graphics g1)
    {
        int i1 = 0;
        byte byte0 = 2;
        boolean flag = false;
        if(a_long_fld < (long)n_int_fld)
        {
            i1 = n_int_fld;
            if(a_long_fld > (long)(n_int_fld - 20000))
                flag = true;
            byte0 = 0;
        } else
        if(a_long_fld < (long)o_int_fld)
        {
            i1 = o_int_fld;
            if(a_long_fld > (long)(o_int_fld - 20000))
                flag = true;
            byte0 = 1;
        }
        int j1 = 0;
        int k1 = 0;
        do
        {
            if(k1 >= h_int_array2d_fld.length)
                break;
            if(h_int_array2d_fld[k1][3] == 0)
            {
                j1 = k1;
                break;
            }
            k1++;
        } while(true);
        int l1 = j1;
        Graphics g2 = g1;
        j j2 = this;
        int i2 = u.h - 93;
        c.a(g2, 32, 0, i2, 16);
        c.a(g2, 11, j2.h_int_array2d_fld[l1][0], i2 + 3, 12);
        v.a_x_array1d_static_fld[2].a(g2, a(j2.h_int_array2d_fld[l1][2], 1000) + "/" + a(j2.h_int_array2d_fld[l1][1], 1000), u.h - 2, 21, 24);
        c.a(g1, 31, byte0, u.h - 93, 0);
        j2 = 3;
        if(flag)
            j2 = 3 + h_int_fld % 12;
        c.a(g1, 31, j2, u.h - 93, 0);
        v.a_x_array1d_static_fld[2].a(g1, c.a(a_long_fld), u.h - 55, 4, 24);
        if(i1 != 0)
            v.a_x_array1d_static_fld[2].a(g1, c.a(i1), u.h - 2, 4, 24);
    }

    private static String a(int i1, int j1)
    {
        if(i1 < j1)
            i1 = (new Integer(i1)).toString();
        else
            i1 = (new Integer(i1 / 1000)).toString() + "K";
        return i1;
    }

    private static void a(Graphics g1, int i1, int j1, int k1)
    {
        c.a(g1, 3, 1, i1, j1);
        c.a = j1 + (43 * (100 - k1)) / 100;
        c.a(g1, 3, 0, i1, j1);
        c.a = 0;
    }

    private void a(Graphics g1, int i1)
    {
        int ai[];
        if((ai = a_ad_array1d_fld[i1].b())[0] == 0)
        {
            if((i1 = ai[6]) != 0)
                i1 = (ai[6] - 1 << 2) + 1;
            if(ai[10] != 90)
            {
                c.a(g1, 1, ai[3] + i1, ai[1], ai[2] - ai[10]);
                if(ai[8] != 0)
                {
                    byte byte0 = 0;
                    if(ai[9] < 3)
                        byte0 = 15;
                    c.a(g1, 1, 127 + h_int_fld % 3, ai[1] + byte0, ai[2] - ai[10]);
                }
            }
            if(ai[6] != 0)
                a(g1, ai[4], ai[5], ai[7]);
            return;
        }
        if(ai[0] == 2)
        {
            i1 = 0;
            if(ai[4] == 1)
                i1 = h_int_fld % 4 <= 1 ? 0 : 1;
            c.a(g1, 2, (ai[3] << 1) + i1, ai[1], ai[2]);
            return;
        }
        if(ai[0] == 3)
        {
            c.a(g1, 6, 5, ai[1], ai[2]);
            if(ai[15] != 90)
            {
                c.a(g1, 6, ai[3] - 1, ai[1], ai[2] - ai[15]);
                int l3 = (ai[2] + 4) - ai[15];
                int k2 = ai[1] + 14;
                Graphics g2 = g1;
                i1 = this;
                int ai1[] = new int[28];
                int l4 = 0;
                for(int i5 = 0; i5 < 10; i5++)
                {
                    int k5 = ((b)((j) (i1)).a_ad_array1d_fld[0]).a(i5);
                    for(int i6 = 0; i6 < k5; i6++)
                        ai1[l4++] = i5;

                }

                int j5 = 0;
                int l5 = 0;
label0:
                do
                {
                    if(l5 >= 7)
                        break;
                    for(int j6 = 0; j6 < 4; j6++)
                    {
                        if(j5 >= l4)
                            break label0;
                        c.a(g2, 17, ai1[j5++], (k2 + l5 * 8) - 4, l3 + 8 * (3 - j6) + 15);
                    }

                    l5++;
                } while(true);
            }
            int i4 = ai[14];
            int l2 = ai[2] + 56;
            int j1 = ai[1] + 17;
            i1 = g1;
            c.a(g1, 16, 0, j1, l2);
            c.a = -(j1 + (i4 * 43) / 100);
            c.a(i1, 16, 1, j1, l2);
            c.a = 0;
            return;
        }
        if(ai[0] != 4)
            break MISSING_BLOCK_LABEL_600;
        if(ai[5] != 1 || e_int_fld == 0 && i1 == 5)
            break MISSING_BLOCK_LABEL_1362;
        if(ai[6] == 1)
        {
            c.a(g1, 4, ai[3], ai[1], ai[2]);
            k_int_fld = ai[3];
        }
        if(ai[3] > 1)
            break MISSING_BLOCK_LABEL_1362;
        this;
        g1;
        ai[4];
        ai[3];
        ai[1] + 16 + (ai[6] != 1 ? -4 : -8);
        ai[2] + 20;
        ai[6];
        true;
        JVM INSTR pop2 ;
        -2;
        JVM INSTR iadd ;
        999;
        a();
        return;
        if(ai[0] == 5)
        {
            i1 = ai[5] - 1 << 2;
            c.a(g1, 5, 28, ai[1], ai[2]);
            c.a(g1, 5, i1, ai[1], ai[2] - ai[9]);
            if(ai[8] == 1)
                c.a(g1, 5, 29 + h_int_fld % 3, ai[1], ai[2] - ai[9]);
            if(ai[5] != 7)
                a(g1, ai[3], ai[4], ai[6]);
            if(ai[7] > 0)
                v.a_x_array1d_static_fld[2].a(g1, (new Integer(ai[7])).toString(), ai[3] + 3, ai[4], 33);
            return;
        }
        if(ai[0] == 6)
        {
            if(ai[5] == 1 && e_int_fld != 0)
            {
                c.a(g1, 8, 7, ai[1], ai[2]);
                if(ai[8] != 90)
                    c.a(g1, 8, ai[3] - 1, ai[1], ai[2] - ai[8]);
            }
            if(ai[4] == 1 && !g_boolean_fld && f_int_fld == -1)
            {
                g_boolean_fld = true;
                d_int_array1d_fld = (new int[] {
                    1, 0, 0, 0, 0
                });
                return;
            }
        } else
        {
            if(ai[0] == 8)
            {
                i1 = 0;
                int k1 = 0;
                do
                {
                    if(k1 >= 5)
                        break;
                    if(ai[k1 + 3] == 1)
                    {
                        i1 = 1;
                        break;
                    }
                    k1++;
                } while(true);
                c.a(g1, 14, i1, 0, 0);
                return;
            }
            if(ai[0] == 1)
            {
                i1 = (ai[5] << 2) + 2 + (h_int_fld % 8 >> 1);
                if(ai[7] != -1)
                    i1 = 18 + ai[7];
                if(ai[8] != -1)
                    i1 = 28 + ai[8];
                int l1 = (ai[1] + c_int_array1d_fld[0]) - c_int_array2d_fld[ai[3]][0];
                int i3 = (ai[2] + c_int_array1d_fld[1]) - c_int_array2d_fld[ai[3]][1];
                c.a(g1, g_int_array1d_static_fld[ai[3]], i1, l1, i3);
                if(ai[8] != -1)
                    c.a(g1, g_int_array1d_static_fld[ai[3]], 33, l1, i3);
                if(ai[8] == -1 && ai[10] == 0)
                {
                    int j4 = ai[6];
                    int j3 = ai[2] + c_int_array1d_fld[1] + d_int_array2d_fld[ai[3]][1];
                    int i2 = ai[1] + c_int_array1d_fld[0] + d_int_array2d_fld[ai[3]][0];
                    i1 = g1;
                    c.a(g1, 19, 0, i2, j3);
                    c.a = -(i2 + (j4 * 18) / 100);
                    c.a(i1, 19, 1, i2, j3);
                    c.a = 0;
                }
                return;
            }
            if(ai[0] == 9)
            {
                i1 = (ai[5] << 2) + 2 + (h_int_fld % 8 >> 1);
                int j2 = (ai[1] + c_int_array1d_fld[0]) - c_int_array2d_fld[ai[3]][0];
                int k3 = (ai[2] + c_int_array1d_fld[1]) - c_int_array2d_fld[ai[3]][1];
                if(ai[3] == 5)
                {
                    int k4 = 0;
                    if(ai[12] == 2)
                        k4 = h_int_array1d_static_fld[h_int_fld % 4];
                    if(ai[12] != 0)
                        i1 = 9;
                    c.a(g1, g_int_array1d_static_fld[ai[3]], i1, j2, k3 + (k4 >> 1));
                    if(ai[6] != -1)
                        c.a(g1, 40, ai[11], j2, k3 + k4, -1, -1, ai[6]);
                    return;
                }
                c.a(g1, g_int_array1d_static_fld[ai[3]], i1, j2, k3);
            }
        }
    }

    private int[] b(int i1)
    {
        int j1 = a_ad_array1d_fld.length;
        for(int k1 = 0; k1 < j1; k1++)
            if((a_ad_array1d_fld[k1] instanceof l) && ((l)a_ad_array1d_fld[k1]).a == i1 && ((l)a_ad_array1d_fld[k1]).b == 0)
                return (new int[] {
                    a_ad_array1d_fld[k1].f, a_ad_array1d_fld[k1].g
                });

        return null;
    }

    private int[] c(int i1)
    {
        i1 = a_ad_array1d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
            if((a_ad_array1d_fld[j1] instanceof z) && ((z)a_ad_array1d_fld[j1]).a_int_fld == 6)
                return (new int[] {
                    a_ad_array1d_fld[j1].f, a_ad_array1d_fld[j1].g, ((z)a_ad_array1d_fld[j1]).a_int_fld
                });

        return null;
    }

    private int[] d(int i1)
    {
        int j1 = a_ad_array1d_fld.length;
        for(int k1 = 0; k1 < j1; k1++)
            if((a_ad_array1d_fld[k1] instanceof g) && ((g)a_ad_array1d_fld[k1]).b == i1 && ((g)a_ad_array1d_fld[k1]).a_int_fld == 0)
                return (new int[] {
                    a_ad_array1d_fld[k1].f, a_ad_array1d_fld[k1].g, ((g)a_ad_array1d_fld[k1]).c
                });

        return null;
    }

    private int[] c()
    {
        int i1 = a_ad_array1d_fld.length;
        for(int j1 = 8; j1 < i1; j1++)
            if(a_ad_array1d_fld[j1] instanceof y)
            {
                ((y)a_ad_array1d_fld[j1]).b();
                if(k_int_fld == 1)
                    return (new int[] {
                        a_ad_array1d_fld[j1].f, a_ad_array1d_fld[j1].g
                    });
                else
                    return null;
            }

        return null;
    }

    public final int a(int i1)
    {
        int j1 = a_ad_array1d_fld.length;
        for(int k1 = 0; k1 < j1; k1++)
            if((a_ad_array1d_fld[k1] instanceof ab) && ((ab)a_ad_array1d_fld[k1]).a == 5 && ((ab)a_ad_array1d_fld[k1]).c == 0 && ((ab)a_ad_array1d_fld[k1]).b == -1)
            {
                ((ab)a_ad_array1d_fld[k1]).b = i1;
                return k1;
            }

        return -1;
    }

    private int[] e(int i1)
    {
        int j1 = a_ad_array1d_fld.length;
        for(int k1 = 0; k1 < j1; k1++)
            if((a_ad_array1d_fld[k1] instanceof ab) && ((ab)a_ad_array1d_fld[k1]).a == i1 && ((ab)a_ad_array1d_fld[k1]).c == 0 && ((ab)a_ad_array1d_fld[k1]).d == 0)
            {
                i1 = ((ab)a_ad_array1d_fld[k1]).b();
                return (new int[] {
                    a_ad_array1d_fld[k1].f, a_ad_array1d_fld[k1].g, i1[12], i1[13]
                });
            }

        return null;
    }

    private void g(int i1)
    {
        int j1 = a_ad_array1d_fld.length;
        for(int k1 = 0; k1 < j1; k1++)
            if(a_ad_array1d_fld[k1] != null && (a_ad_array1d_fld[k1] instanceof ab) && ((ab)a_ad_array1d_fld[k1]).a == 3 && ((ab)a_ad_array1d_fld[k1]).b == i1)
            {
                ((ab)a_ad_array1d_fld[k1]).b = -1;
                return;
            }

    }

    private void a(Graphics g1, int i1, int j1, int k1, int l1, int i2)
    {
        String s = "[";
        if(j1 == 0)
            s = "]";
        v.a_x_array1d_static_fld[2].a(g1, s + a(i1, i2), k1, l1, 17);
    }

    private void c(Graphics g1)
    {
        int ai[];
        int j1 = (ai = c.a(g1, 180, 150, null, 35, 0))[0];
        int i1 = ai[1];
        if(e_int_array2d_fld == null)
        {
            e_int_array2d_fld = new int[4][4];
            for(int k1 = 0; k1 < 4; k1++)
            {
                e_int_array2d_fld[k1][0] = j1 + 15;
                e_int_array2d_fld[k1][1] = i1 + 15 + k1 * 35;
                e_int_array2d_fld[k1][2] = 153;
                e_int_array2d_fld[k1][3] = 25;
            }

        }
        for(int l1 = 0; l1 < 4; l1++)
        {
            if(a_v_fld.r == l1)
            {
                if(f_int_array1d_fld[l1] < 4)
                    f_int_array1d_fld[l1]++;
                c.a(g1, 37, f_int_array1d_fld[l1] + 22, e_int_array2d_fld[l1][0], e_int_array2d_fld[l1][1]);
            } else
            {
                if(f_int_array1d_fld[l1] > 0)
                    f_int_array1d_fld[l1]--;
                c.a(g1, 37, f_int_array1d_fld[l1] + 17, e_int_array2d_fld[l1][0], e_int_array2d_fld[l1][1]);
            }
            v.a_x_array1d_static_fld[1].a(g1, o.a("T" + (l1 + 45)), j1 + 90, e_int_array2d_fld[l1][1] + 4, 17);
        }

    }

    private void d(Graphics g1)
    {
        int ai[];
        int j1 = (ai = c.a(g1, 210, 180, o.a("T27"), 35, 0))[0];
        int i1 = ai[1];
        int k1;
        if((k1 = a_int_array1d_fld[8] / 10) < 10)
            k1 = 10;
        int l1 = a_int_array1d_fld[8];
        a_int_array1d_fld[8] = v.a(a_int_array1d_fld[8], 0, k1);
        a_int_array1d_fld[7] += l1 - a_int_array1d_fld[8];
        if(a_int_array1d_fld[8] == 0)
        {
            if((k1 = a_int_array1d_fld[1] / 10) < 5000)
                k1 = 5000;
            a_int_array1d_fld[1] = v.a(a_int_array1d_fld[1], 0, k1);
        }
        if(a_int_array1d_fld[1] == 0)
        {
            if((k1 = a_int_array1d_fld[0] / 10) < 10)
                k1 = 10;
            int i2 = a_int_array1d_fld[0];
            a_int_array1d_fld[0] = v.a(a_int_array1d_fld[0], 0, k1);
            a_int_array1d_fld[3] += i2 - a_int_array1d_fld[0];
        }
        c.a(g1, 37, 4, j1 + 151, i1 + 89);
        for(k1 = 0; k1 < 4; k1++)
        {
            int j2 = i1 + 32 + k1 * 26;
            if(k1 > 1)
                j2 += 10;
            c.a(g1, 37, 2, j1 + 10, j2 - 5);
            v.a_x_array1d_static_fld[1].a(g1, o.a("T" + (k1 + 28)), j1 + 85, j2, 24);
            a_short_array1d_fld[k1] = (short)c.a(g1, k1 + 26, a_short_array1d_fld[k1], j1 + 16, j2);
            String s;
            if(k1 == 0)
                s = (new Integer(a_int_array1d_fld[7])).toString();
            else
            if(k1 == 1)
                s = c.a(a_int_array1d_fld[k1]);
            else
                s = (new Integer(a_int_array1d_fld[k1])).toString();
            v.a_x_array1d_static_fld[2].a(g1, s, j1 + 142, j2 + 3, 24);
        }

        if(a_int_array1d_fld[4] > 1 && a_int_array1d_fld[1] == 0)
            c.a(g1, 37, a_int_array1d_fld[4] != 2 ? 11 : 12, j1 + 151, i1 + 89);
        k1 = j1 + 81;
        c.a(g1, 37, 5, k1, i1 + 148);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T5"), j1 + 105, i1 + 148 + 4, 17);
    }

    private void e(Graphics g1)
    {
        int i1 = h_int_array2d_fld.length;
        int j1 = 50 + i1 * 30;
        int ai[];
        int l1 = (ai = c.a(g1, 180, j1, null, 35, 1))[0];
        int k1 = ai[1];
        for(int i2 = 0; i2 < i1; i2++)
        {
            int k2 = k1 + 20 + i2 * 30;
            c.a(g1, 37, 14, l1 + 18, k2);
            c.a(g1, 33, h_int_array2d_fld[i2][0], l1 + 20, k2 - 1);
            c.a(g1, 37, h_int_array2d_fld[i2][3] != 0 ? 16 : 15, l1 + 18, k2);
            String s = a(h_int_array2d_fld[i2][2], 10000) + "/" + a(h_int_array2d_fld[i2][1], 10000);
            if(h_int_array2d_fld[i2][3] == 1)
                s = a(h_int_array2d_fld[i2][1], 10000) + "/" + a(h_int_array2d_fld[i2][1], 10000);
            v.a_x_array1d_static_fld[2].a(g1, s, l1 + 130, k2 + 7, 24);
        }

        int j2 = l1 + 66;
        c.a(g1, 37, 5, j2, (k1 + j1) - 30);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T5"), l1 + 90, ((k1 + j1) - 30) + 3, 17);
    }

    private void f(Graphics g1)
    {
        int ai[];
        int j1 = (ai = c.a(g1, 210, 180, o.a("T24"), 35, 0))[0];
        int i1 = ai[1];
        o.a("ILANG", 0);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T25"), j1 + 10, i1 + 17, 20);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T26"), j1 + 203, i1 + 17, 24);
        int k1 = h_int_array2d_fld.length;
        for(int i2 = 0; i2 < k1; i2++)
        {
            int k2 = i1 + 37 + i2 * 27;
            c.a(g1, 37, 1, j1 + 10, k2);
            c.a(g1, 33, h_int_array2d_fld[i2][0], j1 + 12, k2 - 1);
            v.a_x_array1d_static_fld[2].a(g1, "X", j1 + 50, k2 + 7, 20);
            v.a_x_array1d_static_fld[2].a(g1, a(h_int_array2d_fld[i2][1], 10000), j1 + 100, k2 + 7, 24);
        }

        int j2 = (j1 + 210) - 20;
        for(int l2 = 0; l2 < 3; l2++)
        {
            int l1 = i1 + 37 + l2 * 27;
            if(l2 > 0)
                l1 += 27;
            String s = (new Integer(l_int_array1d_fld[l2])).toString();
            if(l2 != 0)
            {
                s = "+" + a(l_int_array1d_fld[l2], 10000);
                String s1 = c.a(n_int_fld);
                if(l2 == 2)
                    s1 = c.a(o_int_fld);
                c.a(g1, 37, 0, j1 + 105, l1);
                v.a_x_array1d_static_fld[2].a(g1, s1, j2 - 45, l1 + 7, 24);
            }
            v.a_x_array1d_static_fld[2].a(g1, s, j2 - 3, l1 + 7, 24);
            c.a(g1, 28, 0, j2, (l1 + 7) - 4);
        }

        int i3 = j1 + 81;
        c.a(g1, 37, 5, i3, i1 + 148);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T5"), j1 + 105, (i1 + 148 + 7) - 4, 17);
    }

    public final int[] a()
    {
        int ai[] = new int[13];
        int i1 = a_ad_array1d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
        {
            int l1;
            if(a_ad_array1d_fld[j1] != null && (a_ad_array1d_fld[j1] instanceof l) && (l1 = ((l)a_ad_array1d_fld[j1]).a) <= 2)
                ai[l1 + 10]++;
        }

        for(int k1 = 0; k1 < 10; k1++)
            ai[k1] = ((b)a_ad_array1d_fld[0]).a_short_array1d_fld[k1];

        return ai;
    }

    public final void b(int i1, int j1)
    {
        int k1 = 0;
        int l1 = a_ad_array1d_fld.length;
        for(int i2 = 0; i2 < l1; i2++)
        {
            if(a_ad_array1d_fld[i2] == null || !(a_ad_array1d_fld[i2] instanceof l) || i1 != ((l)a_ad_array1d_fld[i2]).a)
                continue;
            a_ad_array1d_fld[i2] = null;
            if(++k1 == j1)
                return;
        }

    }

    private void g(Graphics g1)
    {
        int i1 = j_int_array2d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
        {
            if(j_int_array2d_fld[j1] == null)
                continue;
            if(j_int_array2d_fld[j1][0] == 0)
            {
                int k1 = j_int_array2d_fld[j1][1] * j_int_array2d_fld[j1][2];
                v.a_x_array1d_static_fld[0].a(g1, (new Integer(j_int_array2d_fld[j1][3])).toString(), b_int_array2d_static_fld[9][0], b_int_array2d_static_fld[9][1] + k1, 0);
            } else
            if(j_int_array2d_fld[j1][0] == 1)
            {
                int ai[] = c.a(j_int_array2d_fld[j1][2], j_int_array2d_fld[j1][3], j_int_array2d_fld[j1][4], j_int_array2d_fld[j1][5], 5, j_int_array2d_fld[j1][1]);
                c.a(g1, 45, j_int_array2d_fld[j1][6], ai[0], ai[1]);
            } else
            if(j_int_array2d_fld[j1][0] == 2)
            {
                int ai1[] = new int[j_int_array2d_fld[j1][7]];
                for(int k2 = 0; k2 < j_int_array2d_fld[j1][8]; k2++)
                {
                    int l3;
                    if((l3 = (k2 + j_int_array2d_fld[j1][1]) - j_int_array2d_fld[j1][8]) >= 0 && l3 < j_int_array2d_fld[j1][7])
                        ai1[l3] = 1;
                }

                for(int l2 = 0; l2 < j_int_array2d_fld[j1][7]; l2++)
                    if(ai1[l2] == 1)
                    {
                        int ai2[] = c.a(j_int_array2d_fld[j1][2], j_int_array2d_fld[j1][3], j_int_array2d_fld[j1][4], j_int_array2d_fld[j1][5], 10, l2);
                        c.a(g1, 45, j_int_array2d_fld[j1][6], ai2[0], ai2[1]);
                    }

            } else
            if(j_int_array2d_fld[j1][0] == 3)
                c.a(g1, 13, 4 - j_int_array2d_fld[j1][1], j_int_array2d_fld[j1][2], j_int_array2d_fld[j1][3]);
            else
            if(j_int_array2d_fld[j1][0] == 7)
                c.a(g1, 2, (4 - j_int_array2d_fld[j1][1]) + 21, j_int_array2d_fld[j1][2], j_int_array2d_fld[j1][3]);
            else
            if(j_int_array2d_fld[j1][0] == 4)
            {
                if(!o_boolean_fld)
                {
                    j_int_array2d_fld[j1][2] -= j_int_array2d_fld[j1][4];
                    j_int_array2d_fld[j1][4] += 5;
                }
                int l1 = (j_int_array2d_fld[j1][2] + c_int_array1d_fld[0]) - c_int_array2d_fld[5][0];
                int i3 = (j_int_array2d_fld[j1][3] + c_int_array1d_fld[1]) - c_int_array2d_fld[5][1];
                c.a(g1, g_int_array1d_static_fld[5], 10 + h_int_fld % 4, l1, i3);
                if(l1 < -50)
                    j_int_array2d_fld[j1][1] = 1;
            } else
            if(j_int_array2d_fld[j1][0] == 5)
            {
                if(!o_boolean_fld)
                {
                    j_int_array2d_fld[j1][2] += j_int_array2d_fld[j1][4];
                    j_int_array2d_fld[j1][4] += 2;
                }
                int i2 = (j_int_array2d_fld[j1][2] + c_int_array1d_fld[0]) - c_int_array2d_fld[5][0];
                int j3 = (j_int_array2d_fld[j1][3] + c_int_array1d_fld[1]) - c_int_array2d_fld[5][1];
                c.a(g1, g_int_array1d_static_fld[5], 2 + h_int_fld % 4, i2, j3);
                if(i2 > u.h)
                    j_int_array2d_fld[j1][1] = 1;
            } else
            if(j_int_array2d_fld[j1][0] == 6)
            {
                j_int_array2d_fld[j1][3] -= j_int_array2d_fld[j1][4];
                j_int_array2d_fld[j1][4] += 4;
                int j2 = (j_int_array2d_fld[j1][2] + c_int_array1d_fld[0]) - c_int_array2d_fld[5][0];
                int k3 = (j_int_array2d_fld[j1][3] + c_int_array1d_fld[1]) - c_int_array2d_fld[5][1];
                c.a(g1, g_int_array1d_static_fld[j_int_array2d_fld[j1][5]], 9, j2, k3);
                c.a(g1, 44, j_int_array2d_fld[j1][6], j2 + f_int_array2d_fld[j_int_array2d_fld[j1][5]][0], k3 + f_int_array2d_fld[j_int_array2d_fld[j1][5]][1]);
                if(j_int_array2d_fld[j1][6] < 2)
                    j_int_array2d_fld[j1][6]++;
                if(k3 < 30)
                {
                    a(new int[] {
                        7, j2 + f_int_array2d_fld[j_int_array2d_fld[j1][5]][0], 10
                    });
                    j_int_array2d_fld[j1][1] = 1;
                }
            }
            if(o_boolean_fld)
                continue;
            j_int_array2d_fld[j1][1]--;
            if(j_int_array2d_fld[j1][1] == 0)
                j_int_array2d_fld[j1] = null;
        }

    }

    public final void b()
    {
        if(f_int_fld == -1 && !h_boolean_fld && !g_boolean_fld && !e_boolean_fld && !v.e_boolean_static_fld)
        {
            i_boolean_fld = true;
            v.c_boolean_static_fld = false;
        }
        f_boolean_fld = false;
        v.t = -1;
        c_int_fld = -1;
        d_int_fld = -1;
        a(true);
    }

    public final void a(int ai[])
    {
        int i1 = j_int_array2d_fld.length;
        for(int j1 = 0; j1 < i1; j1++)
            if(j_int_array2d_fld[j1] == null)
            {
                if(ai[0] == 0)
                    if(ai[1] == 0)
                    {
                        return;
                    } else
                    {
                        j_int_array2d_fld[j1] = new int[4];
                        j_int_array2d_fld[j1][0] = ai[0];
                        j_int_array2d_fld[j1][1] = 7;
                        j_int_array2d_fld[j1][2] = 3;
                        j_int_array2d_fld[j1][3] = ai[1];
                        return;
                    }
                if(ai[0] == 1)
                {
                    j_int_array2d_fld[j1] = new int[7];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 5;
                    j_int_array2d_fld[j1][2] = ai[2];
                    j_int_array2d_fld[j1][3] = ai[3];
                    j_int_array2d_fld[j1][4] = b_int_array2d_static_fld[10][0];
                    j_int_array2d_fld[j1][5] = b_int_array2d_static_fld[10][1];
                    j_int_array2d_fld[j1][6] = ai[1];
                    return;
                }
                if(ai[0] == 2)
                {
                    j_int_array2d_fld[j1] = new int[9];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 10 + ai[1];
                    j_int_array2d_fld[j1][2] = b_int_array2d_static_fld[10][0];
                    j_int_array2d_fld[j1][3] = b_int_array2d_static_fld[10][1];
                    j_int_array2d_fld[j1][4] = ai[3];
                    j_int_array2d_fld[j1][5] = ai[4];
                    j_int_array2d_fld[j1][6] = ai[2];
                    j_int_array2d_fld[j1][7] = 10;
                    j_int_array2d_fld[j1][8] = ai[1];
                    return;
                }
                if(ai[0] == 3)
                {
                    j_int_array2d_fld[j1] = new int[4];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 4;
                    j_int_array2d_fld[j1][2] = ai[1];
                    j_int_array2d_fld[j1][3] = ai[2];
                    return;
                }
                if(ai[0] == 7)
                {
                    q.a(100);
                    j_int_array2d_fld[j1] = new int[4];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 4;
                    j_int_array2d_fld[j1][2] = ai[1];
                    j_int_array2d_fld[j1][3] = ai[2];
                    return;
                }
                if(ai[0] == 4 || ai[0] == 5)
                {
                    j_int_array2d_fld[j1] = new int[5];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 1000;
                    j_int_array2d_fld[j1][2] = ai[1];
                    j_int_array2d_fld[j1][3] = ai[2];
                    j_int_array2d_fld[j1][4] = ai[3];
                    return;
                }
                if(ai[0] == 6)
                {
                    q.a(100);
                    j_int_array2d_fld[j1] = new int[7];
                    j_int_array2d_fld[j1][0] = ai[0];
                    j_int_array2d_fld[j1][1] = 1000;
                    j_int_array2d_fld[j1][2] = ai[2];
                    j_int_array2d_fld[j1][3] = ai[3];
                    j_int_array2d_fld[j1][4] = ai[1];
                    j_int_array2d_fld[j1][5] = ai[4];
                    j_int_array2d_fld[j1][6] = 0;
                }
                return;
            }

    }

    public final void a(boolean flag)
    {
        if(!flag)
            d_long_fld = System.currentTimeMillis();
        else
            h_int_fld = 0;
        o_boolean_fld = flag;
    }

    public final byte[] a()
    {
        i i1;
        (i1 = new i(6494)).a((byte)e_int_fld);
        i1.a((byte)m_int_fld);
        i1.a((byte)p_int_fld);
        i1.a(g_int_fld);
        i1.a(n_int_fld);
        i1.a(o_int_fld);
        i1.a((byte)f_int_fld);
        i1.a(g_boolean_fld);
        i1.a(j_boolean_fld);
        i1.a(p_boolean_fld);
        i1.a(n_boolean_fld);
        i1.a((byte)h_int_array2d_fld.length);
        for(int j1 = 0; j1 < h_int_array2d_fld.length; j1++)
            i1.a((int[])h_int_array2d_fld[j1]);

        i1.a(a_long_fld);
        i1.a(d_long_fld);
        i1.a((byte)i_int_array2d_fld.length);
        for(int k1 = 0; k1 < i_int_array2d_fld.length; k1++)
            i1.a((int[])i_int_array2d_fld[k1]);

        i1.a((int[])l_int_array1d_fld);
        i1.a((int[])m_int_array1d_fld);
        i1.a((int[])n_int_array1d_fld);
        i1.a((int[])c_int_array1d_fld);
        i1.a((short[])a_short_array1d_fld);
        i1.a((byte)b_int_array2d_static_fld.length);
        for(int l1 = 0; l1 < b_int_array2d_static_fld.length; l1++)
            i1.a((int[])b_int_array2d_static_fld[l1]);

        int i2 = 0;
        for(int j2 = 0; j2 < j_int_array2d_fld.length; j2++)
            if(j_int_array2d_fld[j2] != null)
                i2++;

        i1.a((byte)i2);
        for(int k2 = 0; k2 < j_int_array2d_fld.length; k2++)
            if(j_int_array2d_fld[k2] != null)
                i1.a(j_int_array2d_fld[k2]);

        i1.a((int[])o_int_array1d_fld);
        i2 = 0;
        for(int l2 = 0; l2 < a_ad_array1d_fld.length; l2++)
            if(a_ad_array1d_fld[l2] != null)
                i2++;

        i1.a((byte)i2);
        for(int i3 = 0; i3 < a_ad_array1d_fld.length; i3++)
            if(a_ad_array1d_fld[i3] != null)
                i1.a(a_ad_array1d_fld[i3].b());

        return i1.a();
    }

    public final void b(boolean flag)
    {
        if(flag)
        {
            if(v.a_byte_array1d_static_fld[11] == 0 && !a_v_fld.a(11))
            {
                flag = false;
                int i1 = a_ad_array1d_fld.length;
                for(int j2 = 0; j2 < i1; j2++)
                    if(a_ad_array1d_fld[j2] != null && (a_ad_array1d_fld[j2] instanceof ab) && ((ab)a_ad_array1d_fld[j2]).a == 5 && ((ab)a_ad_array1d_fld[j2]).c == 0)
                        flag++;

                if(flag >= 7)
                    a_v_fld.b(11);
            }
            return;
        }
        if(v.a_byte_array1d_static_fld[14] == 0 && !a_v_fld.a(14) && f_int_fld >= 0)
        {
            if(!q)
            {
                v.b[4]++;
                q = true;
            }
            if(v.b[4] >= 10)
                a_v_fld.b(14);
        }
        if(v.a_byte_array1d_static_fld[0] == 0 && !a_v_fld.a(0) && f_int_fld >= 0 && !p_boolean_fld)
            a_v_fld.b(0);
        if(v.a_byte_array1d_static_fld[8] == 0 && !a_v_fld.a(8))
        {
            if(f_int_fld >= 0 && !n_boolean_fld)
                v.b[8]++;
            if(v.b[8] >= 3)
                a_v_fld.b(8);
        }
        if(v.a_byte_array1d_static_fld[9] == 0 && !a_v_fld.a(9) && e_int_fld > 0 && f_int_fld >= 0 && !d_boolean_fld)
        {
            v.b[3]++;
            d_boolean_fld = true;
            if(v.b[3] >= 3)
                a_v_fld.b(9);
        }
        if(v.a_byte_array1d_static_fld[1] == 0 && !a_v_fld.a(1) && a_long_fld >= 0x249f00L)
            a_v_fld.b(1);
        if(v.a_byte_array1d_static_fld[2] == 0 && !a_v_fld.a(2))
        {
            flag = true;
            int j1 = v.e_byte_array1d_static_fld.length;
            int k2 = 0;
            do
            {
                if(k2 >= j1)
                    break;
                if(v.e_byte_array1d_static_fld[k2] == 0)
                {
                    flag = false;
                    break;
                }
                k2++;
            } while(true);
            if(flag)
                a_v_fld.b(2);
        }
        if(v.a_byte_array1d_static_fld[6] == 0 && !a_v_fld.a(6))
        {
            flag = true;
            int k1 = v.e_byte_array1d_static_fld.length;
            int l2 = 0;
            do
            {
                if(l2 >= k1)
                    break;
                if(v.e_byte_array1d_static_fld[l2] != 3)
                {
                    flag = false;
                    break;
                }
                l2++;
            } while(true);
            if(flag)
                a_v_fld.b(6);
        }
        if(v.a_byte_array1d_static_fld[7] == 0 && !a_v_fld.a(7) && a_v_fld.F >= 0xf4240)
            a_v_fld.b(7);
        if(v.a_byte_array1d_static_fld[15] == 0 && !a_v_fld.a(15))
        {
            flag = true;
            int l1 = 0;
            do
            {
                if(l1 >= a_v_fld.a_byte_array2d_fld.length)
                    break;
                if(a_v_fld.a_byte_array2d_fld[l1][0] != a_v_fld.a_byte_array2d_fld[l1][1])
                {
                    flag = false;
                    break;
                }
                l1++;
            } while(true);
            if(flag)
                a_v_fld.b(15);
        }
        if(v.a_byte_array1d_static_fld[3] == 0 && !a_v_fld.a(3))
        {
            flag = true;
            int i2 = v.k_boolean_static_fld ? v.a_byte_array1d_static_fld.length : 16;
            int i3 = 0;
            do
            {
                if(i3 >= i2)
                    break;
                if(v.a_byte_array1d_static_fld[i3] == 0 && i3 != 3)
                {
                    flag = false;
                    break;
                }
                i3++;
            } while(true);
            if(flag)
                a_v_fld.b(3);
        }
        if(v.a_byte_array1d_static_fld[4] == 0 && !a_v_fld.a(4) && v.b[1] >= 100)
            a_v_fld.b(4);
        if(v.a_byte_array1d_static_fld[10] == 0 && !a_v_fld.a(10) && v.b[2] >= 100)
            a_v_fld.b(10);
        if(v.a_byte_array1d_static_fld[5] == 0 && !a_v_fld.a(5) && !j_boolean_fld && f_int_fld >= 0 && e_int_fld > 0)
            a_v_fld.b(5);
        if(v.a_byte_array1d_static_fld[13] == 0 && !a_v_fld.a(13) && v.b[0] >= 500)
            a_v_fld.b(13);
        if(v.a_byte_array1d_static_fld[16] == 0 && !a_v_fld.a(16) && f_int_fld >= 0 && v.d[3] == 1)
            a_v_fld.b(16);
        if(v.a_byte_array1d_static_fld[17] == 0 && !a_v_fld.a(17) && f_int_fld >= 0 && v.d[1] == 1)
            a_v_fld.b(17);
    }

    private void b(Graphics g1, int i1)
    {
        int j1 = u.h - 150 >> 1;
        int k1 = u.i - 130 >> 1;
        v.i = true;
        c.a(g1, 150, 130, o.a("T118"), 35, 0);
        v.i = false;
        i1 = a_ad_array1d_fld[i1].b();
        c.a(g1, 46, 5, j1 + 17, k1 + 28);
        int ai[];
        if((ai = a_ad_array1d_fld[i1[7]].b())[0] == 0)
            c.a(g1, 1, ai[3] + (ai[6] << 2) + 1, j1 + 22, k1 + 35);
        if(ai[0] == 5)
            c.a(g1, 5, ai[5] << 2, j1 + 30, k1 + 35);
        if(ai[0] == 3)
            c.a(g1, 6, ai[3], j1 + 25, k1 + 31);
        if(ai[0] == 6)
            c.a(g1, 8, ai[3], j1 + 30, k1 + 40);
        a(g1, i1[4], i1[3], j1 + 105, k1 + 81, 9999);
        i_int_array1d_fld = (new int[] {
            j1 + 13, (k1 + 130) - 25, 48, 30
        });
        j_int_array1d_fld = (new int[] {
            j1 + 88, (k1 + 130) - 25, 48, 30
        });
        c.a(g1, 37, 5, j_int_array1d_fld[0], j_int_array1d_fld[1]);
        c.a(g1, 37, 5, i_int_array1d_fld[0], i_int_array1d_fld[1]);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T114"), j_int_array1d_fld[0] + 25, j_int_array1d_fld[1] + 3, 17);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T115"), i_int_array1d_fld[0] + 25, i_int_array1d_fld[1] + 3, 17);
    }

    private void a(Graphics g1, int i1, boolean flag)
    {
        if(d_int_fld == -1)
            d_int_fld = c.a(g1, o.a("T" + (i1 + 82)), 1, 10000, 1000, 17, n.b, 0);
        flag = 14;
        if(o.a("ILANG", 0) == 9 && 14 < v.a_x_array1d_static_fld[0].a() + 2)
            flag = v.a_x_array1d_static_fld[0].a() + 2;
        if((flag = d_int_fld * flag + 46) < 60)
            flag = 60;
        int j1 = v.a_int_array2d_static_fld[i1][0];
        int k1 = v.a_int_array2d_static_fld[i1][1];
        if(i1 == 0)
        {
            j1 = b_int_array2d_static_fld[14][0] + 40;
            k1 = b_int_array2d_static_fld[14][1] + 24;
        } else
        if(i1 == 1)
        {
            int ai[];
            j1 = (ai = b(0))[0] + c_int_array1d_fld[0] + 20;
            k1 = (ai[1] + c_int_array1d_fld[1]) - 15;
        } else
        if(i1 >= 20 && i1 <= 22)
        {
            int ai1[];
            j1 = (ai1 = b(i1 - 20))[0] + c_int_array1d_fld[0] + 10;
            k1 = (ai1[1] + c_int_array1d_fld[1]) - 24;
        } else
        if(i1 == 3)
        {
            int ai2[];
            j1 = (ai2 = c(6))[0] + 20;
            k1 = ai2[1] + 17;
        } else
        if(i1 == 12)
        {
            j1 = b_int_array2d_static_fld[15][0] + 20;
            k1 = b_int_array2d_static_fld[15][1] + 24;
        } else
        if(i1 == 11 || i1 == 13)
        {
            int ai3[];
            j1 = (ai3 = e(5))[0] + c_int_array1d_fld[0] + 10;
            k1 = (ai3[1] + c_int_array1d_fld[1]) - 25;
        } else
        if(i1 == 23 || i1 == 24)
        {
            int ai4[];
            j1 = (ai4 = e((i1 - 23) + 3))[0] + c_int_array1d_fld[0] + 10;
            k1 = (ai4[1] + c_int_array1d_fld[1]) - 25;
        } else
        if(i1 == 17)
        {
            int ai5[];
            j1 = (ai5 = d(0))[0] + 40;
            k1 = ai5[1] + 40;
        } else
        if(i1 >= 25 && i1 <= 30)
        {
            int ai6[];
            j1 = (ai6 = d(i1 - 25))[0] + 40;
            k1 = ai6[1] + 40;
        } else
        if(i1 == 18)
        {
            int ai7[];
            j1 = (ai7 = c())[0] + 20;
            k1 = ai7[1] + 20;
        }
        int ai8[];
        j1 = (ai8 = v.a(j1, k1, 150, flag))[3];
        k1 = ai8[4];
        if(ai8[0] < 0)
            ai8[0] = 5;
        if(ai8[1] < 0)
            ai8[1] = 5;
        if(ai8[0] + 150 > u.h)
            ai8[0] = u.h - 5 - 150;
        if(ai8[1] + flag > u.i)
            ai8[1] = u.i - 5 - flag;
        c.a(g1, 150, flag, null, 35, 1, ai8);
        c.a(g1, o.a("T" + (i1 + 82)), 1, ai8[0] + 75, ai8[1] + 10, 17, n.b, 0);
        i1 = ai8[0] + 51;
        flag = (ai8[1] + flag) - 30;
        c.a(g1, 37, 5, i1, flag);
        v.a_x_array1d_static_fld[1].a(g1, o.a("T5"), ai8[0] + 75, flag + 5, 17);
        i1 = v.a(i_int_fld, ai8[2]);
        c.a(g1, 41, ai8[2], j1 + i1[0], k1 + i1[1]);
    }

    private void h(int i1)
    {
        c_int_fld = i1;
        a(true);
        v.f[i1] = 1;
        c_long_fld = a_long_fld;
    }

    private void f()
    {
        if(c_int_fld != -1 || h_boolean_fld || v.e_boolean_static_fld || v.t != -1 || i_boolean_fld || f_int_fld != -1)
            return;
        int i1 = (int)(a_long_fld - c_long_fld);
        if(v.f[0] == 0 && a_long_fld > 3000L)
        {
            h(0);
            return;
        }
        if(v.f[20] == 0 && i1 > 3000 && b(0) != null)
        {
            h(20);
            return;
        }
        if(v.f[1] == 0 && v.f[0] == 1 && i1 > 3000 && b(0) != null)
        {
            h(1);
            return;
        }
        if(v.f[2] == 0 && v.f[1] == 1 && i1 > 3000)
        {
            h(2);
            return;
        }
        if(v.f[3] == 0 && v.f[2] == 1 && i1 > 3000)
        {
            if((i1 = c(6)) != null && i1[2] == 6)
                h(3);
            return;
        }
        if(v.f[4] == 0 && v.f[3] == 1 && i1 > 3000)
        {
            h(4);
            return;
        }
        if(v.f[5] == 0 && v.f[4] == 1 && ((f)a_ad_array1d_fld[2]).c == 0 && i1 > 3000)
        {
            h(5);
            return;
        }
        if(v.f[7] == 0 && i1 > 5000 && e_int_fld == 1)
        {
            h(7);
            return;
        }
        if(v.f[8] == 0 && i1 > 5000 && e_int_fld == 1 && ((b)a_ad_array1d_fld[0]).c > 0 && j_int_array2d_fld[0] == null)
        {
            h(8);
            return;
        }
        if(v.f[9] == 0 && v.f[8] == 1 && ((b)a_ad_array1d_fld[0]).c > 0 && g_boolean_fld)
        {
            h(9);
            return;
        }
        if(v.f[11] == 0 && e(5) != null)
        {
            h(11);
            return;
        }
        if(v.f[12] == 0 && v.f[11] == 1 && c_int_fld == -1 && e(5) != null)
        {
            h(12);
            return;
        }
        if(v.f[13] == 0 && c_int_fld == -1 && e(5) != null)
        {
            if((i1 = e(5))[2] != 0)
                h(13);
            return;
        }
        if(v.f[17] == 0 && g_int_fld >= 200 && d(0) != null)
        {
            h(17);
            return;
        }
        if(v.f[18] == 0 && c() != null)
        {
            h(18);
            return;
        }
        if(v.f[19] == 0 && !((b)a_ad_array1d_fld[0]).a_boolean_fld)
        {
            h(19);
            return;
        }
        if(v.f[21] == 0 && i1 > 5000 && b(1) != null)
        {
            h(21);
            return;
        }
        if(v.f[22] == 0 && i1 > 5000 && b(2) != null)
        {
            h(22);
            return;
        }
        if(v.f[23] == 0 && i1 > 5000 && e(3) != null)
        {
            h(23);
            return;
        }
        if(v.f[24] == 0 && i1 > 5000 && e(4) != null)
        {
            h(24);
            return;
        }
        if(v.f[25] == 0 && i1 > 5000 && d(0) != null)
        {
            if((i1 = d(0))[2] > 0)
                h(25);
            return;
        }
        if(v.f[26] == 0 && i1 > 5000 && d(1) != null)
        {
            if((i1 = d(1))[2] > 0)
                h(26);
            return;
        }
        if(v.f[27] == 0 && i1 > 5000 && d(2) != null)
        {
            if((i1 = d(2))[2] > 0)
                h(27);
            return;
        }
        if(v.f[28] == 0 && i1 > 5000 && d(3) != null)
        {
            if((i1 = d(3))[2] > 0)
                h(28);
            return;
        }
        if(v.f[29] == 0 && i1 > 5000 && d(4) != null)
        {
            if((i1 = d(4))[2] > 0)
                h(29);
            return;
        }
        if(v.f[30] == 0 && i1 > 5000 && d(5) != null)
        {
            int ai[];
            if((ai = d(5))[2] > 0)
                h(30);
            return;
        }
        if(v.f[31] == 0 && ((f)a_ad_array1d_fld[2]).b == 5 && ((f)a_ad_array1d_fld[2]).a == 0)
            h(31);
    }

    public final void c(int i1)
    {
        n_boolean_fld = true;
        if(p_int_array1d_fld[i1] == 0)
            p_int_array1d_fld[i1] = 50;
    }

    private void h(Graphics g1)
    {
        for(int i1 = 0; i1 < p_int_array1d_fld.length; i1++)
        {
            if(p_int_array1d_fld[i1] <= 0)
                continue;
            int j1;
            int k1 = j1 = h_int_fld % 2;
            if(i1 == 1)
                j1 = -j1;
            int l1 = i1;
            if(p_int_array1d_fld[i1] < 2 || p_int_array1d_fld[i1] > 49)
                l1 += 2;
            c.a(g1, 43, l1, v.a_int_array2d_static_fld[i1 + 32][0] + j1, v.a_int_array2d_static_fld[i1 + 32][1] + k1);
            p_int_array1d_fld[i1]--;
        }

    }

    public final void d(int i1)
    {
        a_int_array2d_fld = new int[100][5];
        int j1 = 0;
        j1++;
        a(0, g_int_array2d_fld[0], 5, 2);
        g_int_array2d_fld[1][1] = 15;
        j1++;
        a(1, g_int_array2d_fld[1], 10, -1);
        j1++;
        a(2, g_int_array2d_fld[13], 3, 0);
        j1++;
        a(3, g_int_array2d_fld[15], 11, -1);
        int ai[] = a_ad_array1d_fld[4].b();
        if(e_int_fld != 0 && ai[5] != 0)
        {
            j1++;
            a(4, g_int_array2d_fld[14], 6, 4);
        }
        int k1 = -1;
        a_ad_array1d_fld[7].b();
        if(a())
        {
            k1 = j1;
            a(j1++, new int[] {
                15, 15
            }, 8, 0);
        }
        if(o_int_array1d_fld != null)
        {
            for(int l1 = 0; l1 < 6; l1++)
                if(o_int_array1d_fld[l1] != 0)
                    a(j1++, g_int_array2d_fld[n_int_array1d_fld[l1] + 7], 0, o_int_array1d_fld[l1]);

        }
        int ai1[] = e(5);
        m_boolean_fld = ai1 != null;
        if(m_boolean_fld)
        {
            a(j1++, g_int_array2d_fld[16], 12, -1);
            b_int_array1d_fld = a_int_array2d_fld[j1 - 1];
        } else
        if(i1 == 1 || i1 == 2 && k1 == -1 || i1 == 3)
            b_int_array1d_fld = a_int_array2d_fld[2];
        b_int_fld = j1;
    }

    public final void c()
    {
label0:
        {
            if(!o_boolean_fld)
                h_int_fld++;
            else
                i_int_fld++;
            if(b_long_static_fld < 0L)
            {
                for(int i1 = 0; i1 < a_java_lang_String_array1d_static_fld.length; i1++)
                {
                    long l1;
                    if(((l1 = o.a(a_java_lang_String_array1d_static_fld[i1], 4682)) & 0xffffffff80000000L) != 0L)
                        continue;
                    if(--l1 <= 0L)
                        b_long_static_fld = System.currentTimeMillis();
                    o.a(a_java_lang_String_array1d_static_fld[i1], String.valueOf(l1));
                }

            }
            if(b_long_static_fld > 0L)
            {
                a(true);
                a_v_fld.a(99);
                return;
            }
            if(v.e_boolean_static_fld)
                return;
            if(f_int_fld > 0)
            {
                f_int_fld--;
                c_int_fld = -1;
                d_int_fld = -1;
                g_boolean_fld = false;
                h_boolean_fld = false;
                e_boolean_fld = false;
                f_boolean_fld = false;
                i_boolean_fld = false;
                v.t = -1;
                if(f_int_fld == 0)
                {
                    v.f();
                    v.c_boolean_static_fld = false;
                    if(!l_boolean_fld)
                    {
                        if(o.b)
                            v.a(2, false);
                        else
                        if(a_int_array1d_fld[4] == 1)
                            v.a(2, false);
                        else
                        if(a_int_array1d_fld[4] == 2)
                            v.a(8, false);
                        else
                        if(a_int_array1d_fld[4] == 3)
                            v.a(7, false);
                        l_boolean_fld = true;
                    }
                    a(true);
                }
            }
            j j2;
            Object obj = new int[(j2 = this).a_ad_array1d_fld.length][];
            int ai2[][] = new int[j2.a_ad_array1d_fld.length][];
            int ai1[][] = new int[50][];
            int j1 = 0;
            int j4 = 0;
            int i5 = 0;
            int j5 = j2.a_ad_array1d_fld.length;
            for(int k5 = 0; k5 < j5; k5++)
            {
                if(j2.a_ad_array1d_fld[k5] == null)
                    continue;
                if(j2.a_ad_array1d_fld[k5] instanceof l)
                {
                    obj[j1++] = ((l)j2.a_ad_array1d_fld[k5]).a();
                    continue;
                }
                if(j2.a_ad_array1d_fld[k5] instanceof z)
                {
                    ai2[j4++] = ((z)j2.a_ad_array1d_fld[k5]).a();
                    continue;
                }
                if(!(j2.a_ad_array1d_fld[k5] instanceof ab))
                    continue;
                int ai3[];
                if((ai3 = ((ab)j2.a_ad_array1d_fld[k5]).a())[5] == 0)
                    obj[j1++] = ((ab)j2.a_ad_array1d_fld[k5]).a();
                if(ai3[5] == 1)
                    ai1[i5++] = ((ab)j2.a_ad_array1d_fld[k5]).a();
            }

            for(int l5 = 0; l5 < i5; l5++)
            {
                for(int i6 = 0; i6 < j1; i6++)
                    if(c.a(ai1[l5], obj[i6]))
                    {
                        j2.a(new int[] {
                            6, 10, j2.a_ad_array1d_fld[obj[i6][4]].f, j2.a_ad_array1d_fld[obj[i6][4]].g, obj[i6][6]
                        });
                        j2.a_ad_array1d_fld[obj[i6][4]] = null;
                        j2.q = true;
                    }

                for(int j6 = 0; j6 < j4; j6++)
                    if(c.a(ai1[l5], ai2[j6]))
                    {
                        j2.a(new int[] {
                            7, j2.a_ad_array1d_fld[ai2[j6][4]].f, j2.a_ad_array1d_fld[ai2[j6][4]].g
                        });
                        j2.a_ad_array1d_fld[ai2[j6][4]] = null;
                    }

            }

            b(true);
            if(!o_boolean_fld && b_int_array1d_fld[2] == 11)
            {
                int ai[];
                (ai = k_int_array1d_fld)[0] += 10 * ai[1];
                if(ai[0] >= 100)
                {
                    ai[0] = 100;
                    ai[1] = -1;
                }
                if(ai[0] <= 0)
                {
                    ai[0] = 0;
                    ai[1] = 1;
                }
                k_int_array1d_fld = ai;
            }
            if(!o_boolean_fld)
            {
                int k1 = (int)(System.currentTimeMillis() - d_long_fld);
                a_long_fld += k1;
                long l4 = a_long_fld;
                ai = this;
                for(int k2 = 0; k2 < ((j) (ai)).i_int_array2d_fld.length; k2++)
                    if(((j) (ai)).i_int_array2d_fld[k2][1] == 0 && (long)((j) (ai)).i_int_array2d_fld[k2][0] < l4 && ai.a(5))
                        ((j) (ai)).i_int_array2d_fld[k2][1] = 1;

                int i2 = a_ad_array1d_fld.length;
                for(int l2 = 0; l2 < i2; l2++)
                {
                    if(a_ad_array1d_fld[l2] == null)
                        continue;
                    a_ad_array1d_fld[l2].a(k1);
                    if(!a_ad_array1d_fld[l2].a_())
                        continue;
                    if((a_ad_array1d_fld[l2] instanceof ab) && ((ab)a_ad_array1d_fld[l2]).a == 5)
                        g(l2);
                    if(a_ad_array1d_fld[l2] instanceof z)
                        a(new int[] {
                            7, a_ad_array1d_fld[l2].f, a_ad_array1d_fld[l2].g
                        });
                    a_ad_array1d_fld[l2] = null;
                }

                d_long_fld = System.currentTimeMillis();
            }
            i2 = this;
            l4 = new int[3];
            int k4 = ((j) (i2)).a_ad_array1d_fld.length;
            for(int i3 = 8; i3 < k4; i3++)
                if(((j) (i2)).a_ad_array1d_fld[i3] != null && (((j) (i2)).a_ad_array1d_fld[i3] instanceof l))
                    l4[((l)((j) (i2)).a_ad_array1d_fld[i3]).a]++;

            for(int j3 = 0; j3 < 3; j3++)
                ((j) (i2)).m_int_array1d_fld[j3 + 10] = l4[j3];

            ((j) (i2)).m_int_array1d_fld[13] = ((j) (i2)).g_int_fld;
            for(int k3 = 0; k3 < ((j) (i2)).h_int_array2d_fld.length; k3++)
            {
                if(((j) (i2)).h_int_array2d_fld[k3][3] != 0)
                    continue;
                ((j) (i2)).h_int_array2d_fld[k3][2] = ((j) (i2)).m_int_array1d_fld[((j) (i2)).h_int_array2d_fld[k3][0]];
                if(((j) (i2)).h_int_array2d_fld[k3][2] >= ((j) (i2)).h_int_array2d_fld[k3][1])
                {
                    ((j) (i2)).h_int_array2d_fld[k3][3] = 1;
                    ((j) (i2)).h_int_array2d_fld[k3][5] = -10;
                    i2.j_int_fld = 7;
                }
            }

            if(((j) (i2)).f_int_fld == -1)
            {
                int l3 = 0;
                do
                {
                    if(l3 >= ((j) (i2)).h_int_array2d_fld.length)
                        break;
                    if(((j) (i2)).h_int_array2d_fld[l3][3] == 0)
                    {
                        i2.f_int_fld = -1;
                        break label0;
                    }
                    l3++;
                } while(true);
                i2.h_boolean_fld = false;
                i2.e_boolean_fld = false;
                i2.f_boolean_fld = false;
                i2.g_boolean_fld = false;
                i2.i_boolean_fld = false;
                i2.c_int_fld = -1;
                i2.d_int_fld = -1;
                v.t = -1;
                i2.f_int_fld = 10;
            }
            if(((j) (i2)).a_int_array1d_fld == null)
            {
                i2.a_int_array1d_fld = new int[10];
                ((j) (i2)).a_int_array1d_fld[0] = ((j) (i2)).g_int_fld;
                ((j) (i2)).a_int_array1d_fld[1] = (int)((j) (i2)).a_long_fld;
                int i4 = ((j) (i2)).l_int_array1d_fld[0];
                ((j) (i2)).a_int_array1d_fld[4] = 1;
                if(((j) (i2)).a_long_fld < (long)((j) (i2)).n_int_fld)
                {
                    i4 += ((j) (i2)).l_int_array1d_fld[1];
                    ((j) (i2)).a_int_array1d_fld[4] = 3;
                } else
                if(((j) (i2)).a_long_fld < (long)((j) (i2)).o_int_fld)
                {
                    i4 += ((j) (i2)).l_int_array1d_fld[2];
                    ((j) (i2)).a_int_array1d_fld[4] = 2;
                }
                ((j) (i2)).a_int_array1d_fld[2] = i4;
                ((j) (i2)).a_int_array1d_fld[3] = ((j) (i2)).a_v_fld.F;
                ((j) (i2)).a_int_array1d_fld[5] = i4;
                ((j) (i2)).a_int_array1d_fld[6] = ((j) (i2)).g_int_fld;
                ((j) (i2)).a_int_array1d_fld[7] = 1000;
                ((j) (i2)).a_int_array1d_fld[8] = 0;
                if(((j) (i2)).a_long_fld < (long)((j) (i2)).o_int_fld)
                    ((j) (i2)).a_int_array1d_fld[8] = (int)(((long)((j) (i2)).o_int_fld - ((j) (i2)).a_long_fld) / 20L);
                ((j) (i2)).a_int_array1d_fld[9] = ((j) (i2)).a_int_array1d_fld[7] + ((j) (i2)).a_int_array1d_fld[8];
            }
        }
        f();
    }

    public final void e(int i1)
    {
        if(g_boolean_fld && c_int_fld == -1)
        {
            if(i1 == 6)
                ((a)a_ad_array1d_fld[4]).a(0, null);
            if(i1 == 5 || i1 == 4)
                if(d_int_array1d_fld[4] == 0)
                    ((a)a_ad_array1d_fld[4]).a(1, d_int_array1d_fld);
                else
                if(d_int_array1d_fld[4] == 1)
                    if(d_int_array1d_fld[0] == 1)
                        ((a)a_ad_array1d_fld[4]).a(2, null);
                    else
                        ((a)a_ad_array1d_fld[4]).a(3, null);
            if(i1 == 1 && d_int_array1d_fld[0] != 0)
                d_int_array1d_fld[0]--;
            if(i1 == 0 && d_int_array1d_fld[0] != 1)
                d_int_array1d_fld[0]++;
            if(i1 == 2)
                if(d_int_array1d_fld[1] > 0)
                    d_int_array1d_fld[1]--;
                else
                if(d_int_array1d_fld[2] > 0)
                    d_int_array1d_fld[2]--;
                else
                if(d_int_array1d_fld[2] == 0)
                    d_int_array1d_fld[4] = 1;
            if(i1 == 3)
            {
                if(d_int_array1d_fld[4] == 1)
                {
                    d_int_array1d_fld[4] = 0;
                    return;
                }
                i1 = 4;
                if(d_int_array1d_fld[2] == 0 && d_int_array1d_fld[1] + d_int_array1d_fld[2] + 1 >= d_int_array1d_fld[3])
                    i1 = d_int_array1d_fld[3] - 1;
                if(d_int_array1d_fld[1] < i1)
                {
                    d_int_array1d_fld[1]++;
                    return;
                }
                if(d_int_array1d_fld[1] + d_int_array1d_fld[2] + 1 < d_int_array1d_fld[3])
                    d_int_array1d_fld[2]++;
            }
            return;
        }
        if(v.t != -1)
        {
            if(i1 == 4)
                ((y)a_ad_array1d_fld[v.t]).b();
            if(i1 == 4 || i1 == 6)
            {
                v.t = -1;
                a(false);
            }
            return;
        }
        if(b_int_array1d_fld[2] == 11)
        {
            if(i1 == 5)
            {
                if((i1 = a_ad_array1d_fld[2].b())[5] < 5)
                {
                    ((f)a_ad_array1d_fld[2]).b(k_int_array1d_fld[0]);
                    return;
                }
                ((f)a_ad_array1d_fld[2]).a();
            }
            return;
        }
        if(i1 != 5)
            break MISSING_BLOCK_LABEL_994;
        if(b_int_array1d_fld[2] == 10)
        {
            e_boolean_fld = true;
            a(true);
            return;
        }
        if(b_int_array1d_fld[2] == 8)
        {
            if(a())
            {
                f_boolean_fld = true;
                o_boolean_fld = true;
                return;
            }
            break MISSING_BLOCK_LABEL_1203;
        }
        if(b_int_array1d_fld[2] == 0)
        {
            if(((g)a_ad_array1d_fld[b_int_array1d_fld[3]]).c == 0)
            {
                a_ad_array1d_fld[b_int_array1d_fld[3] + 1].a();
                return;
            }
            if((i1 = ((g)a_ad_array1d_fld[b_int_array1d_fld[3]]).a()) != 0)
                a_ad_array1d_fld[b_int_array1d_fld[3]].a();
            return;
        }
        if(b_int_array1d_fld[2] == 5)
        {
            if((i1 = ((f)a_ad_array1d_fld[b_int_array1d_fld[3]]).a()) != 0)
                a_ad_array1d_fld[b_int_array1d_fld[3]].a();
            return;
        }
        if(b_int_array1d_fld[2] != 6)
            break MISSING_BLOCK_LABEL_808;
        if((i1 = e_int_fld == 0 ? 0 : 1) == 0) goto _L2; else goto _L1
_L1:
        int j1;
        int k1;
        j1 = ((j) (i1 = this)).a_ad_array1d_fld.length;
        k1 = 0;
_L7:
        if(k1 >= j1)
            break; /* Loop/switch isn't completed */
        int l1;
        if(((j) (i1)).a_ad_array1d_fld[k1] == null || !(((j) (i1)).a_ad_array1d_fld[k1] instanceof l) || (l1 = ((l)((j) (i1)).a_ad_array1d_fld[k1]).a) > 2) goto _L4; else goto _L3
_L3:
        true;
          goto _L5
_L4:
        k1++;
        if(true) goto _L7; else goto _L6
_L6:
        k1 = 0;
_L11:
        if(k1 >= 10)
            break; /* Loop/switch isn't completed */
        if(((b)((j) (i1)).a_ad_array1d_fld[0]).a_short_array1d_fld[k1] <= 0) goto _L9; else goto _L8
_L8:
        true;
          goto _L5
_L9:
        k1++;
        if(true) goto _L11; else goto _L10
_L10:
        false;
_L5:
        i1;
_L2:
        if(i1 != 0)
            a_ad_array1d_fld[b_int_array1d_fld[3]].a();
        return;
        if(b_int_array1d_fld[2] == 12)
        {
            if((i1 = e(5)) != null)
            {
                i1 = a_ad_array1d_fld.length;
                for(j1 = 0; j1 < i1; j1++)
                    if((a_ad_array1d_fld[j1] instanceof ab) && ((ab)a_ad_array1d_fld[j1]).a == 5 && ((ab)a_ad_array1d_fld[j1]).c == 0)
                        ((ab)a_ad_array1d_fld[j1]).a();

            }
            return;
        }
        if(b_int_array1d_fld[2] != 3)
            break MISSING_BLOCK_LABEL_1203;
        j1 = ((j) (i1 = this)).a_ad_array1d_fld.length;
        k1 = 0;
_L16:
        if(k1 >= j1)
            break; /* Loop/switch isn't completed */
        if((((j) (i1)).a_ad_array1d_fld[k1] == null || !(((j) (i1)).a_ad_array1d_fld[k1] instanceof z)) && !i1.a(((j) (i1)).a_ad_array1d_fld[k1])) goto _L13; else goto _L12
_L12:
        true;
          goto _L14
_L13:
        k1++;
        if(true) goto _L16; else goto _L15
_L15:
        false;
_L14:
        JVM INSTR dup ;
        i1;
        JVM INSTR ifeq 993;
           goto _L17 _L18
_L17:
        break MISSING_BLOCK_LABEL_979;
_L18:
        break MISSING_BLOCK_LABEL_993;
        a_ad_array1d_fld[b_int_array1d_fld[3]].a();
        return;
        if(i1 == 13)
        {
            if(b_int_array1d_fld[2] == 0)
            {
                if((i1 = ((y)a_ad_array1d_fld[b_int_array1d_fld[3] + 1]).b()) != 0)
                    a_ad_array1d_fld[b_int_array1d_fld[3] + 1].a();
                return;
            }
            if(b_int_array1d_fld[2] == 5)
            {
                if((i1 = ((y)a_ad_array1d_fld[b_int_array1d_fld[3] + 1]).b()) != 0)
                    a_ad_array1d_fld[b_int_array1d_fld[3] + 1].a();
                return;
            }
            if(b_int_array1d_fld[2] == 6)
            {
                if((i1 = ((y)a_ad_array1d_fld[b_int_array1d_fld[3] + 1]).b()) != 0)
                    a_ad_array1d_fld[b_int_array1d_fld[3] + 1].a();
                return;
            }
            if(b_int_array1d_fld[2] == 3 && (i1 = ((y)a_ad_array1d_fld[b_int_array1d_fld[3] + 1]).b()) != 0)
                a_ad_array1d_fld[b_int_array1d_fld[3] + 1].a();
        }
    }

    public final void f(int i1)
    {
        ((e)a_ad_array1d_fld[7]).b(i1);
        d(2);
    }

    public final void d()
    {
        c_int_fld = -1;
        d_int_fld = -1;
        i_boolean_fld = true;
        f_int_array1d_fld = new int[4];
        a_v_fld.r = 0;
        v.f();
        v.c_boolean_static_fld = false;
        a(true);
    }

    private boolean a()
    {
        int ai[] = a_ad_array1d_fld[7].b();
        boolean flag = false;
        int i1 = 0;
        do
        {
            if(i1 >= 5)
                break;
            if(ai[i1 + 3] == 1)
            {
                flag = true;
                break;
            }
            i1++;
        } while(true);
        return flag;
    }

    private void a(int i1, int ai[], int j1, int k1)
    {
        int i2 = k1;
        int l1 = j1;
        k1 = ai[1];
        j1 = ai[0];
        ai = i1;
        i1 = this;
        a_int_array2d_fld[ai][0] = j1;
        ((j) (i1)).a_int_array2d_fld[ai][1] = k1;
        ((j) (i1)).a_int_array2d_fld[ai][2] = l1;
        ((j) (i1)).a_int_array2d_fld[ai][3] = i2;
    }

    private void c(Graphics g1, int i1)
    {
        int ai[];
        int k1 = (ai = c.a(g1, 180, 150, null, 35, 1))[0];
        int j1 = ai[1];
        int ai1[] = a_ad_array1d_fld[7].b();
        byte byte0 = ((byte)(v.c_int_array1d_static_fld[2] == 0 ? 1 : 2));
        for(int l1 = 0; l1 < 5; l1++)
        {
            int i3 = ai1[l1 + 3];
            int l2 = e.a[l1] / byte0;
            int k2 = l1;
            int j2 = j1 + l1 * 25 + 15;
            int i2 = k1 + 10;
            Graphics g2 = g1;
            c.a(g1, 37, 3, i2, j2);
            c.a(g2, 14, k2 + 2, i2, j2);
            c.a(g2, 47, 13, i2 + 45, j2 + 2);
            c.a(g2, 37, i3 + 27, i2, j2);
            v.a_x_array1d_static_fld[0].a(g2, (new Integer(l2)).toString(), i2 + 65, j2 + 4, 0);
        }

        c.a(g1, 49, i_int_fld % 4, k1 + 140, j1 + i1 * 25 + 24);
    }

    public final void a(Graphics g1)
    {
        if(g_boolean_fld)
        {
            Graphics g2 = g1;
            j j2 = this;
            int l2 = u.i - 260 >> 1;
            int ai5[][] = ((a)j2.a_ad_array1d_fld[4]).a;
            j2.d_int_array1d_fld[3] = 0;
            for(int l4 = 0; l4 < 13; l4++)
                if(ai5[l4][1] != 0)
                    j2.d_int_array1d_fld[3]++;

            if(j2.d_int_array1d_fld[3] == 0 && j2.d_int_array1d_fld[4] == 0)
            {
                j2.d_int_array1d_fld[0] = 0;
                j2.d_int_array1d_fld[4] = 1;
            }
            g2.setColor(0x72b6f1);
            g2.setClip(0, 0, u.h, u.i);
            g2.fillRect(0, 0, u.h, u.i);
            c.a(g2, 53, 0, 0, 0);
            c.a(g2, 53, 1, 0, u.i - 172);
            c.a(g2, 53, 4, 0, l2);
            v.a_x_array1d_static_fld[0].a(g2, o.a("T49"), u.h >> 1, 4, 17);
            int i1;
            if((i1 = j2.d_int_array1d_fld[3]) > 5)
                i1 = 5;
            for(int i5 = 0; i5 < i1; i5++)
            {
                int l5 = i5 * 22 + 65 + l2;
                int ai8[] = ai5[i5 + j2.d_int_array1d_fld[2]];
                int l6 = l5;
                byte byte0 = 33;
                Graphics g4 = g2;
                c.a(g2, 47, ai8[0], 35, l6 + 2);
                c.a(g4, 47, 13, 91, l6 + 2);
                c.a(g4, 37, 13, 33, l6);
                v.a_x_array1d_static_fld[1].a(g4, "X" + (new Integer(ai8[1])).toString(), 63, l6 + 4, 0);
                v.a_x_array1d_static_fld[1].a(g4, (new Integer(ai8[2])).toString(), 111, l6 + 4, 0);
            }

            if(j2.d_int_array1d_fld[2] != 0)
                c.a(g2, 53, 2, 0, l2);
            if(j2.d_int_array1d_fld[2] + 5 < j2.d_int_array1d_fld[3])
                c.a(g2, 53, 3, 0, l2);
            int j5;
            int i6;
            if(j2.d_int_array1d_fld[4] == 0)
            {
                j5 = j2.d_int_array1d_fld[0] * 28 + 158;
                i6 = j2.d_int_array1d_fld[1] * 22 + 76 + l2;
            } else
            {
                i6 = l2 + 46;
                if(j2.d_int_array1d_fld[0] == 0)
                    j5 = 65;
                else
                    j5 = 170;
            }
            if(j2.c_int_fld == -1)
                c.a(g2, 49, j2.i_int_fld % 4, j5, i6);
            Object obj;
            obj = (obj = j2.a_ad_array1d_fld[4].b())[3] - 1;
            c.a(g2, 8, ((int) (obj)), 20, l2 + 195);
            v.a_x_array1d_static_fld[0].a(g2, (new Integer(((a)j2.a_ad_array1d_fld[4]).c)).toString(), 75, l2 + 230, 17);
            obj = c.a(38, ((int) (obj)), 0, l2);
            int ai1[][];
            l2 = (ai1 = ((a)j2.a_ad_array1d_fld[4]).b_int_array2d_fld).length;
            for(int j4 = 0; j4 < l2; j4++)
            {
                int k5 = obj[j4][0] + 90;
                int j6 = obj[j4][1] + 195;
                c.a(g2, 10, 0, k5, j6);
                if(ai1[j4][0] != -1)
                    c.a(g2, 11, ai1[j4][0], k5, j6 + 4);
                int j7 = ai1[j4][2];
                int i7 = j6 + 6;
                int k6 = k5 + 15;
                Graphics g5 = g2;
                c.a(g2, 12, 1, k6, i7);
                c.a = i7 + (18 * (100 - j7)) / 100;
                c.a(g5, 12, 0, k6, i7);
                c.a = 0;
            }

            if(c_int_fld != -1)
                a(g1, c_int_fld, false);
            return;
        }
        c.a(g1, 0, 0, -v.x);
        int ai9[];
        for(int j1 = 0; j1 < 6; j1++)
        {
            if(o_int_array1d_fld == null || o_int_array1d_fld[j1] == 0)
                continue;
            int i3 = o_int_array1d_fld[j1];
            Graphics g3 = g1;
            j j3 = this;
            int ai6[];
            ai9 = a_ad_array1d_fld[i3].b();
            ai6 = ai9;
            if(ai9[0] != 0)
                continue;
            c.a(g3, 39, ai6[9], 0, -v.x);
            if(ai6[6] != 0)
                c.a(g3, 1, 126, ai6[1], ai6[2]);
        }

        int ai[] = b();
        for(int l1 = 0; l1 < a_ad_array1d_fld.length; l1++)
        {
            int ai3[];
            if(a_ad_array1d_fld[l1] != null && ((ai3 = a_ad_array1d_fld[l1].b())[0] == 1 || ai3[0] == 9))
                c.a(g1, g_int_array1d_static_fld[ai3[3]], 1, (ai3[1] + c_int_array1d_fld[0]) - c_int_array2d_fld[ai3[3]][0], (ai3[4] + c_int_array1d_fld[1]) - c_int_array2d_fld[ai3[3]][1]);
        }

        int ai2[][] = ((p)a_ad_array1d_fld[6]).a;
        for(int k2 = 0; k2 < 10; k2++)
        {
            for(int k3 = 0; k3 < 10; k3++)
                if(ai2[k2][k3] != 0)
                {
                    int k4 = ai2[k2][k3] - 1 >> 2;
                    c.a(g1, 22, k4, k2 * 14 + a_ad_array1d_fld[6].f, k3 * l_int_fld + a_ad_array1d_fld[6].g);
                }

        }

        if(m_boolean_fld)
            c.a(g1, 54, h_int_fld % 2, b_int_array2d_static_fld[15][0], b_int_array2d_static_fld[15][1]);
        a(g1, 2);
        a(g1, 3);
        int i2 = ai.length;
        for(int l3 = 0; l3 < i2; l3++)
            if(a_ad_array1d_fld[ai[l3]] != null)
                a(g1, ai[l3]);

        for(int i4 = 0; i4 < 8; i4++)
            if(a_ad_array1d_fld[i4] != null && i4 != 2 && i4 != 3 && (i4 != 7 || i4 == 7))
                a(g1, i4);

        int ai4[] = a_ad_array1d_fld[2].b();
        c.a(g1, 52, 0, b_int_array2d_static_fld[14][0], b_int_array2d_static_fld[14][1]);
        if(b_int_array1d_fld[2] == 11 && ai4[5] < 5)
        {
            c.a(g1, 52, 1, b_int_array2d_static_fld[14][0], b_int_array2d_static_fld[14][1]);
            c.a(g1, 52, 2, b_int_array2d_static_fld[14][0], (b_int_array2d_static_fld[14][1] + (k_int_array1d_fld[0] * 28) / 100) - 4);
        }
        b(g1);
        c.a(g1, 26, h_int_fld % 8, 10, u.i - 31);
        v.a_x_array1d_static_fld[2].a(g1, (new Integer(g_int_fld)).toString(), 25, u.i - 27, 0);
        int ai7[];
        if(a_ad_array1d_fld[4] != null && (ai7 = ((a)a_ad_array1d_fld[4]).a()) != null)
        {
            int k1 = (60 * ai7[0]) / 100;
            c.a(g1, 9, ai7[1] + 1, (b_int_array2d_static_fld[11][0] + 65) - k1, b_int_array2d_static_fld[11][1] + 18 + ai7[3]);
            if(ai7[2] == 0)
                v.a_x_array1d_static_fld[2].a(g1, (new Integer(((a)a_ad_array1d_fld[4]).c)).toString(), ((b_int_array2d_static_fld[11][0] + 65) - k1) + 19, b_int_array2d_static_fld[11][1] + 19 + ai7[3], 20);
            else
                v.a_x_array1d_static_fld[2].a(g1, (new Integer(((a)a_ad_array1d_fld[4]).c)).toString(), (b_int_array2d_static_fld[11][0] + 65) - k1, b_int_array2d_static_fld[11][1] + 19 + ai7[3], 24);
        }
        g(g1);
        h(g1);
        if(j_int_fld != -1)
        {
            c.a(g1, 34, 7 - j_int_fld, u.h - 140, 0);
            j_int_fld--;
        }
        if(h_boolean_fld)
            f(g1);
        if(f_int_fld == 0)
            d(g1);
        if(i_boolean_fld)
            c(g1);
        if(c_int_fld == -1 && f_int_fld != 0 && !h_boolean_fld && !i_boolean_fld && !e_boolean_fld && !f_boolean_fld && !v.e_boolean_static_fld)
            c.a(g1, 49, h_int_fld % 4, b_int_array1d_fld[0], b_int_array1d_fld[1]);
        if(c_int_fld != -1)
            a(g1, c_int_fld, false);
        if(e_boolean_fld)
            e(g1);
        if(v.t != -1)
            b(g1, v.t);
        if(f_boolean_fld)
            c(g1, a_int_fld);
        if(v.e_boolean_static_fld)
            d(g1, v.k_int_static_fld);
    }

    static int b()
    {
        return Math.abs((new Random()).nextInt() % 473 + 4209);
    }

    private void d(Graphics g1, int i1)
    {
        byte byte0 = 0;
        if(u.c == 3)
            byte0 = 13;
        if(u.c == 1)
            byte0 = 35;
        if(byte0 == 0)
            return;
        int ai[];
        int k1 = (ai = c.a(g1, 210, 180, o.a("M8"), byte0, 0))[0];
        int j1 = ai[1];
        String s = " ";
        int l1;
        if(i1 == 1)
        {
            if((l1 = (s = o.a("GTSQ")).indexOf("%ss%")) != -1)
                s = s.substring(0, l1) + "" + v.a_k_array1d_static_fld[v.z].a + s.substring(l1 + "%ss%".length());
        } else
        if(i1 == 2)
            s = o.a("VIPREG");
        else
        if(i1 == 3)
            s = o.a("er" + t.k);
        d_int_fld = c.a(g1, s, 0, k1 + 105, j1 + 17, 17, 193, 0);
        if(u.c == 3)
            byte0 = 14;
        if(u.c == 1)
            byte0 = 37;
        if(i1 == 1 || i1 == 2)
        {
            i_int_array1d_fld = (new int[] {
                k1 + 24, (j1 + 180) - 30, 48, 30
            });
            j_int_array1d_fld = (new int[] {
                (k1 + 210) - 24 - 48, (j1 + 180) - 30, 48, 30
            });
            c.a(g1, byte0, 5, j_int_array1d_fld[0], j_int_array1d_fld[1]);
            c.a(g1, byte0, 5, i_int_array1d_fld[0], i_int_array1d_fld[1]);
            v.a_x_array1d_static_fld[1].a(g1, o.a("T114"), j_int_array1d_fld[0] + 25, j_int_array1d_fld[1] + 3, 17);
            v.a_x_array1d_static_fld[1].a(g1, o.a("T115"), i_int_array1d_fld[0] + 25, i_int_array1d_fld[1] + 3, 17);
            return;
        } else
        {
            int i2 = u.h - 48 >> 1;
            i_int_array1d_fld = (new int[] {
                i2, (j1 + 180) - 30 - 15, 48, 30
            });
            c.a(g1, byte0, 5, i_int_array1d_fld[0], i_int_array1d_fld[1]);
            v.a_x_array1d_static_fld[1].a(g1, o.a("T5"), i_int_array1d_fld[0] + 25, i_int_array1d_fld[1] + 3, 17);
            return;
        }
    }

    public int a_int_fld;
    public int a_int_array2d_fld[][];
    public int b_int_fld;
    private int f_int_array1d_fld[];
    public v a_v_fld;
    public static int b_int_array2d_static_fld[][] = null;
    private static final int g_int_array1d_static_fld[] = {
        15, 20, 21, 23, 24, 25
    };
    private static final int h_int_array1d_static_fld[] = {
        3, -3, 5, -5
    };
    private int d_int_array2d_fld[][];
    public boolean a_boolean_fld;
    private boolean l_boolean_fld;
    public boolean b_boolean_fld;
    public int c_int_array2d_fld[][];
    public boolean c_boolean_fld;
    private boolean m_boolean_fld;
    public int a_int_array1d_fld[];
    private int h_int_fld;
    private int i_int_fld;
    private int j_int_fld;
    private int e_int_array2d_fld[][];
    public boolean d_boolean_fld;
    public int c_int_fld;
    public int d_int_fld;
    private long c_long_fld;
    private int k_int_fld;
    private int f_int_array2d_fld[][];
    public boolean e_boolean_fld;
    private int l_int_fld;
    private int i_int_array1d_fld[];
    private int j_int_array1d_fld[];
    public int b_int_array1d_fld[];
    private int g_int_array2d_fld[][];
    public boolean f_boolean_fld;
    private int k_int_array1d_fld[];
    public int e_int_fld;
    public boolean g_boolean_fld;
    public boolean h_boolean_fld;
    public boolean i_boolean_fld;
    private boolean n_boolean_fld;
    public int f_int_fld;
    public int g_int_fld;
    private int h_int_array2d_fld[][];
    public long a_long_fld;
    private boolean o_boolean_fld;
    private int i_int_array2d_fld[][];
    private int l_int_array1d_fld[];
    private int m_int_fld;
    private int n_int_fld;
    private int o_int_fld;
    private int m_int_array1d_fld[];
    private int n_int_array1d_fld[];
    private long d_long_fld;
    private short a_short_array1d_fld[];
    public int c_int_array1d_fld[];
    public boolean j_boolean_fld;
    private boolean p_boolean_fld;
    private boolean q;
    private int p_int_fld;
    private int j_int_array2d_fld[][];
    private int o_int_array1d_fld[];
    public ad a_ad_array1d_fld[];
    public int d_int_array1d_fld[];
    private int p_int_array1d_fld[];
    static byte a_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 86, 101, 110, 
        100, 111, 114
    };
    static byte b_byte_array1d_static_fld[] = {
        77, 105, 99, 114, 111, 69, 100, 105, 116, 105, 
        111, 110, 46, 86, 101, 114, 115, 105, 111, 110
    };
    static byte c_byte_array1d_static_fld[] = {
        77, 105, 99, 114, 111, 69, 100, 105, 116, 105, 
        111, 110, 46, 83, 68, 75
    };
    static byte d_byte_array1d_static_fld[] = {
        109, 105, 99, 114, 111, 101, 100, 105, 116, 105, 
        111, 110, 46, 112, 108, 97, 116, 102, 111, 114, 
        109
    };
    static byte e_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 86, 101, 114, 
        115, 105, 111, 110
    };
    static byte f_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 67, 76, 68, 
        67
    };
    static byte g_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 74, 97, 114, 
        45, 83, 105, 122, 101
    };
    static byte h_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 74, 97, 114, 
        45, 85, 82, 76
    };
    static byte i_byte_array1d_static_fld[] = {
        77, 73, 68, 108, 101, 116, 45, 77, 73, 68, 
        80
    };
    static byte j_byte_array1d_static_fld[] = {
        47, 77, 69, 84, 65, 45, 73, 78, 70, 47, 
        77, 65, 78, 73, 70, 69, 83, 84, 46, 77, 
        70
    };
    static byte k_byte_array1d_static_fld[] = {
        102, 105, 108, 101, 58, 47, 47
    };
    static byte l_byte_array1d_static_fld[] = {
        104, 116, 116, 112, 58, 47, 47
    };
    static byte m_byte_array1d_static_fld[] = {
        104, 116, 116, 112, 115, 58, 47, 47
    };
    public static long b_long_static_fld = -57685L;
    public static final String a_java_lang_String_array1d_static_fld[];
    static int e_int_array1d_static_fld[] = {
        b() >> 1, b() >> 1, b() >> 1, b() >> 1
    };
    public static String a_java_lang_String_static_fld;
    public static String b_java_lang_String_static_fld;
    public static String c_java_lang_String_static_fld;
    public static String d_java_lang_String_static_fld;
    public static boolean k_boolean_static_fld = false;

    static 
    {
        byte abyte0[] = new byte[16];
        abyte0[0] = 77;
        abyte0[1] = 73;
        abyte0[2] = 68;
        abyte0[3] = 108;
        abyte0[4] = 101;
        abyte0[5] = 116;
        abyte0[6] = 45;
        abyte0[7] = 72;
        abyte0[8] = 101;
        abyte0[9] = 97;
        abyte0[10] = 112;
        abyte0[11] = 45;
        abyte0[12] = 83;
        abyte0[13] = 105;
        abyte0[14] = 122;
        abyte0[15] = 101;
        a_java_lang_String_array1d_static_fld = (new String[] {
            new String(a_byte_array1d_static_fld), new String(d_byte_array1d_static_fld), new String(g_byte_array1d_static_fld), new String(h_byte_array1d_static_fld)
        });
    }
}
