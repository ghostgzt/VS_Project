 

import java.io.DataInputStream;
import javax.microedition.lcdui.*;

public final class x
{

    public x()
    {
        d = 0;
        e = 0;
        f = 2;
        a_int_fld = 2;
    }

    public final void a(String s)
    {
        if(v.g)
        {
            e = 0;
            a_java_lang_String_array1d_fld = new String[1];
            a_javax_microedition_lcdui_Image_array1d_fld = new Image[1];
            a_int_array2d_fld = new int[1][];
            a_byte_array2d_fld = new byte[1][];
            for(int i = 0; i < a_javax_microedition_lcdui_Image_array1d_fld.length; i++)
                try
                {
                    a_javax_microedition_lcdui_Image_array1d_fld[i] = Image.createImage(s + "font_" + i + ".png");
                    StringBuffer stringbuffer = new StringBuffer();
                    DataInputStream datainputstream = new DataInputStream(k.a(s + "font_" + i + ".dat"));
                    try
                    {
                        int j = datainputstream.readByte() & 0xff;
                        d = datainputstream.readByte();
                        f = datainputstream.readByte();
                        a_int_fld = datainputstream.readByte();
                        a_int_array2d_fld[i] = new int[j + 1];
                        a_byte_array2d_fld[i] = new byte[j + 1];
                        for(int l = 0; l < j; l++)
                        {
                            String s1 = datainputstream.readUTF();
                            stringbuffer.append(s1);
                            a_byte_array2d_fld[i][l] = datainputstream.readByte();
                            a_int_array2d_fld[i][l + 1] = a_int_array2d_fld[i][l] + a_byte_array2d_fld[i][l];
                        }

                        datainputstream.close();
                        e++;
                    }
                    catch(Exception _ex) { }
                    a_java_lang_String_array1d_fld[i] = stringbuffer.toString();
                }
                catch(Exception _ex) { }

        }
    }

    public final void a(Graphics g, String s, int i, int j, int l)
    {
        g.setClip(0, 0, u.h, u.i);
        if(o.a("ILANG", 0) == 9 && !v.g)
            v.g = c.a(s);
        if(!v.g)
            try
            {
                if((l & 1) == 1)
                    i -= a(s) >> 1;
                if((l & 8) == 8)
                    i -= a(s);
                if((l & 0x40) == 64)
                    j -= a() >> 1;
                if((l & 0x20) == 32)
                    j -= a();
                g.setColor(0);
                g.drawString(s, i - 1, j, 20);
                g.drawString(s, i, j - 1, 20);
                g.drawString(s, i + 1, j, 20);
                g.drawString(s, i, j + 1, 20);
                g.setColor(c);
                g.drawString(s, i, j, 20);
            }
            catch(Exception _ex) { }
        else
        if(v.g)
        {
            int i1 = g.getClipX();
            int j1 = g.getClipY();
            int k1 = g.getClipWidth();
            int l1 = g.getClipHeight();
            if((l & 1) == 1)
                i -= a(s) >> 1;
            if((l & 8) == 8)
                i -= a(s);
            if((l & 0x40) == 64)
                j -= a() - a_int_fld;
            if((l & 0x20) == 32)
                j -= a();
            l = i;
label0:
            for(int i2 = 0; i2 < s.length(); i2++)
            {
                if(s.charAt(i2) == ' ')
                {
                    l += f;
                    continue;
                }
                if(s.charAt(i2) == '~')
                    continue;
                int j2 = 0;
                do
                {
                    if(j2 >= e)
                        continue label0;
                    if((i = a_java_lang_String_array1d_fld[j2].indexOf(s.charAt(i2))) != -1)
                    {
                        g.clipRect(l, j, a_byte_array2d_fld[j2][i], a_javax_microedition_lcdui_Image_array1d_fld[j2].getHeight());
                        g.drawImage(a_javax_microedition_lcdui_Image_array1d_fld[j2], l - a_int_array2d_fld[j2][i], j, 20);
                        g.setClip(i1, j1, k1, l1);
                        l = (l += a_byte_array2d_fld[j2][i]) + d;
                        continue label0;
                    }
                    j2++;
                } while(true);
            }

        }
        if(o.a("ILANG", 0) == 9)
            v.g = false;
    }

    public final int a()
    {
        if(!v.g)
            return Font.getDefaultFont().getHeight();
        else
            return a_javax_microedition_lcdui_Image_array1d_fld[0].getHeight();
    }

    public final int a(String s)
    {
        if(o.a("ILANG", 0) == 9 && !v.g)
            v.g = c.a(s);
        if(!v.g)
        {
            int i = Font.getDefaultFont().stringWidth(s);
            if(o.a("ILANG", 0) == 9)
                v.g = false;
            return i;
        }
        if(v.g)
        {
            int j = 0;
label0:
            for(int i1 = 0; i1 < s.length(); i1++)
            {
                if(s.charAt(i1) == ' ')
                {
                    j += f;
                    continue;
                }
                if(s.charAt(i1) == '~')
                    continue;
                int j1 = 0;
                do
                {
                    if(j1 >= e)
                        continue label0;
                    int l;
                    if((l = a_java_lang_String_array1d_fld[j1].indexOf(s.charAt(i1))) != -1)
                    {
                        j = (j += a_byte_array2d_fld[j1][l]) + d;
                        continue label0;
                    }
                    j1++;
                } while(true);
            }

            return j;
        } else
        {
            return 0;
        }
    }

    private static int b = 0;
    private static int c = 0xffffff;
    private Image a_javax_microedition_lcdui_Image_array1d_fld[];
    private int a_int_array2d_fld[][];
    private byte a_byte_array2d_fld[][];
    private String a_java_lang_String_array1d_fld[];
    private int d;
    private int e;
    private int f;
    public int a_int_fld;

}
