 


public final class l extends ad
{

    public static void b(int i1)
    {
        if(i1 == 2)
        {
            c_int_array1d_static_fld = (new int[] {
                1, 3, 5
            });
            return;
        }
        if(i1 == 1)
        {
            c_int_array1d_static_fld = (new int[] {
                2, 5, 10
            });
            return;
        } else
        {
            c_int_array1d_static_fld = (new int[] {
                3, 8, 15
            });
            return;
        }
    }

    public l(int i1, j j1, int k1)
    {
        j = 0;
        super.e = i1;
        a_j_fld = j1;
        a_int_fld = k1;
        b();
        super.f = v.b(c_int_fld);
        super.g = v.b(d);
        b_int_fld = super.g + j1.c[1] + 30;
        super.b[1] = super.f;
        super.b[2] = super.g;
        if(k1 < 3)
            k = a_int_array1d_static_fld[k1];
        r = -1;
        o = 10;
        n = 0;
        q = 0;
        p = 0;
        s = -1;
        b_short_array1d_fld = new short[2];
        a_short_array1d_fld = a(true);
        m = 0;
        l = 100;
    }

    public l(j j1, byte abyte0[])
    {
        super(abyte0);
        j = 0;
        a_j_fld = j1;
        super.a.a();
        a_int_fld = super.a.a();
        k = super.a.a();
        b_int_fld = super.a.a();
        l = super.a.a();
        m = super.a.a();
        n = super.a.a();
        o = super.a.a();
        p = super.a.b();
        q = super.a.b();
        r = super.a.a();
        s = super.a.a();
        a_short_array1d_fld = super.a.a();
        b_short_array1d_fld = super.a.a();
        super.a = null;
        b();
    }

    private void b()
    {
        c_int_fld = a_j_fld.c[2];
        d = a_j_fld.c[3];
        super.b = new int[11];
        super.b[0] = 1;
        super.b[3] = a_int_fld;
    }

    protected final byte[] a()
    {
        i i1;
        (i1 = new i(512)).a((byte)1);
        i1.a((byte)a_int_fld);
        i1.a((byte)k);
        i1.a((byte)b_int_fld);
        i1.a((byte)l);
        i1.a((byte)m);
        i1.a((byte)n);
        i1.a((byte)o);
        i1.a(p);
        i1.a(q);
        i1.a((byte)r);
        i1.a((byte)s);
        i1.a(a_short_array1d_fld);
        i1.a(b_short_array1d_fld);
        return i1.a();
    }

    public final void a(int i1)
    {
        j++;
        p += i1;
        i1 = 0;
        int j1 = ((p)a_j_fld.a[6]).c;
        if(p > 1000)
        {
            p = 0;
            i1 = 1;
            if(n <= 2)
                k -= c_int_array1d_static_fld[a_int_fld];
        }
        if(b_int_fld != 0)
        {
            b_int_fld = v.a(b_int_fld, 0, o);
            o += 10;
            if(b_int_fld == 0)
                a_short_array1d_fld = a(true);
        } else
        {
            int k1 = 3;
            if(l <= 40)
                k1 = 6;
            if(a_short_array1d_fld != null)
            {
                int l1 = c.b(super.f, a_short_array1d_fld[0], k1);
                k1 = c.b(super.g, a_short_array1d_fld[1], k1);
                if(l1 == super.f && k1 == super.g)
                    a_short_array1d_fld = null;
                if(r == -1)
                {
                    super.f = l1;
                    super.g = k1;
                }
            }
            if(l <= 40 && n == 0 && j1 > 0)
            {
                a_short_array1d_fld = a(false);
                if(a_short_array1d_fld != null)
                    n = 1;
            }
            if(b_short_array1d_fld != null && a_short_array1d_fld == null && n == 1)
            {
                n = 4;
                p = 1000;
            }
            if(b_short_array1d_fld != null && i1 != 0 && n == 4)
            {
                s = v.b(2) * 5;
                byte byte0 = 10;
                short word0 = b_short_array1d_fld[1];
                int i2 = b_short_array1d_fld[0];
                p p1 = (p)a_j_fld.a[6];
                int j2 = 10;
                if(p1.a_int_array2d_fld[i2][word0] < 10)
                    j2 = p1.a_int_array2d_fld[i2][word0];
                p1.a_int_array2d_fld[i2][word0] -= j2;
                if((i2 = j2 << 1) == 0)
                {
                    s = -1;
                    b_short_array1d_fld = null;
                    if(k < a_int_array1d_static_fld[a_int_fld] && j1 != 0)
                    {
                        a_short_array1d_fld = a(false);
                        n = 1;
                    } else
                    {
                        n = 0;
                    }
                }
                k += i2;
                if(k > a_int_array1d_static_fld[a_int_fld])
                    k = a_int_array1d_static_fld[a_int_fld];
            }
            l = (k * 100) / a_int_array1d_static_fld[a_int_fld];
            if(a_short_array1d_fld == null && n != 4)
            {
                a_short_array1d_fld = a(true);
                n = 0;
            }
        }
        if(i1 != 0)
        {
            q++;
            if(q == 20)
            {
                a_j_fld.a(a_int_fld + 6, super.f + a_j_fld.c[0], (super.g + a_j_fld.c[1]) - 12);
                q = 0;
            }
        }
        if(l <= 0)
        {
            if(n != 3)
            {
                n = 3;
                r = 0;
                return;
            }
            r++;
        }
    }

    protected final boolean a_()
    {
        return r == 9;
    }

    public final void a()
    {
    }

    public final int[] b()
    {
        super.b[1] = super.f;
        if(b_int_fld != 0)
            super.b[2] = super.g - b_int_fld;
        else
            super.b[2] = super.g;
        super.b[4] = super.g;
        super.b[5] = m;
        super.b[6] = l;
        if(s != -1)
            super.b[7] = s + j % 5;
        else
            super.b[7] = -1;
        super.b[8] = r < 0 ? -1 : r / 3;
        super.b[10] = b_int_fld;
        return super.b;
    }

    public final int[] a()
    {
        int ai[];
        (ai = new int[7])[4] = super.e;
        ai[0] = super.f;
        ai[1] = super.g;
        if(b_int_fld != 0)
            ai[2] = -1000;
        ai[2] = 6;
        ai[3] = 3;
        ai[5] = 0;
        ai[6] = a_int_fld;
        return ai;
    }

    private short[] a(boolean flag)
    {
        short aword0[];
        aword0 = new short[3];
        if(flag)
        {
            aword0[0] = (short)v.b(c_int_fld);
            aword0[1] = (short)v.b(d);
            break MISSING_BLOCK_LABEL_339;
        }
        int l1 = ((ad) (flag)).g;
        int j1 = ((ad) (flag)).f;
        p p1 = (p)((l) (flag)).a_j_fld.a[6];
        j1 /= p1.a_int_fld;
        l1 /= p1.b;
        short aword1[];
        (aword1 = new short[3])[2] = 1000;
        for(int i2 = 0; i2 < 10; i2++)
        {
            for(int j2 = 0; j2 < 10; j2++)
            {
                if(p1.a_int_array2d_fld[i2][j2] == 0)
                    continue;
                int k2 = j1 - i2;
                int l2 = l1 - j2;
                if((k2 = c.a(k2 * k2 + l2 * l2)) < 0)
                    k2 = -k2;
                if(aword1[2] > k2)
                {
                    aword1[0] = (short)i2;
                    aword1[1] = (short)j2;
                    aword1[2] = (short)k2;
                }
            }

        }

        (flag = this).b_short_array1d_fld = aword1[2] == 100 ? null : aword1;
        if(((l) (flag)).b_short_array1d_fld == null) goto _L2; else goto _L1
_L1:
        int i1;
        i1 = ((p)((l) (flag)).a_j_fld.a[6]).a_int_fld;
        int k1 = ((p)((l) (flag)).a_j_fld.a[6]).b;
        i1 = i1 * ((l) (flag)).b_short_array1d_fld[0] + v.b(i1);
        flag = k1 * ((l) (flag)).b_short_array1d_fld[1] + v.b(k1);
        new int[] {
            i1, flag
        };
          goto _L3
_L2:
        null;
_L3:
        JVM INSTR dup ;
        flag;
        JVM INSTR ifnull 337;
           goto _L4 _L5
_L4:
        break MISSING_BLOCK_LABEL_315;
_L5:
        break MISSING_BLOCK_LABEL_337;
        aword0[0] = (short)flag[0];
        aword0[1] = (short)flag[1];
        n = 0;
        break MISSING_BLOCK_LABEL_339;
        return null;
        flag = c.b(super.f, super.g, aword0[0], aword0[1]);
        aword0[2] = 3;
        if(flag >= 30)
            break MISSING_BLOCK_LABEL_371;
        flag;
        JVM INSTR ifge 378;
           goto _L6 _L7
_L6:
        break MISSING_BLOCK_LABEL_371;
_L7:
        break MISSING_BLOCK_LABEL_378;
        if(flag < 330)
            break MISSING_BLOCK_LABEL_382;
        aword0[2] = 2;
        if(flag >= 160 && flag <= 200)
            aword0[2] = 0;
        if(flag > 200 && flag < 330)
            aword0[2] = 1;
        m = aword0[2];
        return aword0;
    }

    private j a_j_fld;
    private static final int a_int_array1d_static_fld[] = {
        50, 80, 150
    };
    private static int c_int_array1d_static_fld[];
    private int c_int_fld;
    private int d;
    private int j;
    public int a_int_fld;
    private int k;
    public int b_int_fld;
    private int l;
    private int m;
    private int n;
    private int o;
    private int p;
    private int q;
    private int r;
    private int s;
    private short a_short_array1d_fld[];
    private short b_short_array1d_fld[];

}
