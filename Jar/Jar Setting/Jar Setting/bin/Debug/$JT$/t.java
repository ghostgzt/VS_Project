 

import java.io.*;
import java.util.Vector;
import javax.microedition.io.*;
import javax.microedition.lcdui.*;

public final class t
    implements CommandListener, ItemStateListener
{

    public t()
    {
    }

    public final void itemStateChanged(Item item)
    {
        if(item == a_javax_microedition_lcdui_ChoiceGroup_static_fld && a_javax_microedition_lcdui_Form_static_fld != null)
        {
            a_javax_microedition_lcdui_ChoiceGroup_static_fld.getSelectedFlags(a_boolean_array1d_static_fld);
            if(a_boolean_array1d_static_fld[0])
            {
                a_javax_microedition_lcdui_Form_static_fld.setTitle(o.a("REGI"));
                m = a_javax_microedition_lcdui_Form_static_fld.append(c_javax_microedition_lcdui_TextField_static_fld);
                n = a_javax_microedition_lcdui_Form_static_fld.append(d_javax_microedition_lcdui_TextField_static_fld);
                o = a_javax_microedition_lcdui_Form_static_fld.append(e_javax_microedition_lcdui_TextField_static_fld);
                c_javax_microedition_lcdui_TextField_static_fld.setString("");
                d_javax_microedition_lcdui_TextField_static_fld.setString("");
                e_javax_microedition_lcdui_TextField_static_fld.setString("");
                return;
            }
            a_javax_microedition_lcdui_Form_static_fld.setTitle(o.a("AUTO"));
            a_javax_microedition_lcdui_Form_static_fld.delete(o);
            a_javax_microedition_lcdui_Form_static_fld.delete(n);
            a_javax_microedition_lcdui_Form_static_fld.delete(m);
        }
    }

    public final void commandAction(Command command, Displayable displayable)
    {
        if(displayable == a_javax_microedition_lcdui_Form_static_fld)
            if(command == a_javax_microedition_lcdui_Command_static_fld)
            {
                a_javax_microedition_lcdui_ChoiceGroup_static_fld.getSelectedFlags(a_boolean_array1d_static_fld);
                if(a_boolean_array1d_static_fld[0])
                {
                    a_java_lang_String_static_fld = a_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                    b_java_lang_String_static_fld = b_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                    c_java_lang_String_static_fld = d_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                    d_java_lang_String_static_fld = e_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                    c_boolean_static_fld = true;
                    if(a_java_lang_String_static_fld.length() > 0 && b_java_lang_String_static_fld.length() > 0 && b_java_lang_String_static_fld.equals(c_javax_microedition_lcdui_TextField_static_fld.getString().trim()))
                    {
                        l = 1;
                        return;
                    } else
                    {
                        c_javax_microedition_lcdui_TextField_static_fld.setString("");
                        return;
                    }
                }
                a_java_lang_String_static_fld = a_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                b_java_lang_String_static_fld = b_javax_microedition_lcdui_TextField_static_fld.getString().trim();
                c_boolean_static_fld = false;
                if(a_java_lang_String_static_fld.length() > 0 && b_java_lang_String_static_fld.length() > 0)
                {
                    l = 1;
                    return;
                }
            } else
            if(command == b_javax_microedition_lcdui_Command_static_fld)
                l = 2;
    }

    public static boolean a(int i1)
    {
        return (new t()).b(i1);
    }

    private boolean b(int i1)
    {
        boolean flag = false;
        boolean flag1 = v.c;
        v.f();
        v.c = false;
        l = 0;
        a_javax_microedition_lcdui_Command_static_fld = new Command(o.a("T5"), 4, 1);
        b_javax_microedition_lcdui_Command_static_fld = new Command(o.a("T146"), 3, 2);
        (a_javax_microedition_lcdui_ChoiceGroup_static_fld = new ChoiceGroup(null, 2)).append(o.a("NOPOL"), null);
        a_javax_microedition_lcdui_TextField_static_fld = new TextField(o.a("LOGIN"), "", 25, 0);
        b_javax_microedition_lcdui_TextField_static_fld = new TextField(o.a("PAROL"), "", 25, 0x10000);
        c_javax_microedition_lcdui_TextField_static_fld = new TextField(o.a("PAROL2"), "", 25, 0x10000);
        d_javax_microedition_lcdui_TextField_static_fld = new TextField(o.a("EMAIL"), "", 25, 1);
        e_javax_microedition_lcdui_TextField_static_fld = new TextField(o.a("NTEL"), "", 25, 3);
        Object obj;
        if(v.a_k_array1d_static_fld[v.z].a_boolean_fld)
            obj = o.a("AUTO");
        else
            obj = o.a("REGI");
        a_javax_microedition_lcdui_Form_static_fld = new Form(((String) (obj)));
        try
        {
            a_javax_microedition_lcdui_Form_static_fld.append(a_javax_microedition_lcdui_TextField_static_fld);
            a_javax_microedition_lcdui_Form_static_fld.append(b_javax_microedition_lcdui_TextField_static_fld);
            a_javax_microedition_lcdui_Form_static_fld.append(a_javax_microedition_lcdui_ChoiceGroup_static_fld);
            if(!v.a_k_array1d_static_fld[v.z].a_boolean_fld)
            {
                a_boolean_array1d_static_fld[0] = true;
                a_javax_microedition_lcdui_ChoiceGroup_static_fld.setSelectedFlags(a_boolean_array1d_static_fld);
                m = a_javax_microedition_lcdui_Form_static_fld.append(c_javax_microedition_lcdui_TextField_static_fld);
                n = a_javax_microedition_lcdui_Form_static_fld.append(d_javax_microedition_lcdui_TextField_static_fld);
                o = a_javax_microedition_lcdui_Form_static_fld.append(e_javax_microedition_lcdui_TextField_static_fld);
            } else
            {
                a_javax_microedition_lcdui_TextField_static_fld.setString(v.a_k_array1d_static_fld[v.z].c);
                b_javax_microedition_lcdui_TextField_static_fld.setString(v.a_k_array1d_static_fld[v.z].d);
            }
            a_javax_microedition_lcdui_Form_static_fld.addCommand(a_javax_microedition_lcdui_Command_static_fld);
            a_javax_microedition_lcdui_Form_static_fld.addCommand(b_javax_microedition_lcdui_Command_static_fld);
            a_javax_microedition_lcdui_Form_static_fld.setCommandListener(this);
            a_javax_microedition_lcdui_Form_static_fld.setItemStateListener(this);
        }
        catch(Exception _ex) { }
        Displayable displayable = ((Display) (obj = Display.getDisplay(gameMIDlet.a_gameMIDlet_static_fld))).getCurrent();
        Thread.yield();
        gameMIDlet.a_int_static_fld = 2;
        ((Display) (obj)).setCurrent(a_javax_microedition_lcdui_Form_static_fld);
        while(l == 0) 
            try
            {
                Thread.sleep(5L);
            }
            catch(Exception _ex) { }
        gameMIDlet.a_int_static_fld = 1;
        ((Display) (obj)).setCurrent(displayable);
        a_javax_microedition_lcdui_Form_static_fld = null;
        a_javax_microedition_lcdui_ChoiceGroup_static_fld = null;
        a_javax_microedition_lcdui_Command_static_fld = b_javax_microedition_lcdui_Command_static_fld = null;
        if(l == 1)
        {
            flag = true;
            if(i1 == 1 && v.a_k_array1d_static_fld[v.z].a_boolean_fld && v.a_k_array1d_static_fld[v.z].b_boolean_fld && (c_boolean_static_fld || !v.a_k_array1d_static_fld[v.z].c.equals(a_java_lang_String_static_fld) || !v.a_k_array1d_static_fld[v.z].d.equals(b_java_lang_String_static_fld)))
            {
                v.A = 3;
                v.d = true;
                v.j = 5;
            } else
            {
                a(i1);
            }
        }
        System.gc();
        v.a(50L);
        if(flag1)
            v.a(v.H, true);
        return flag;
    }

    public static void a(int i1)
    {
        e_java_lang_String_static_fld = null;
        int j1;
        if(c_boolean_static_fld)
            j1 = a();
        else
            j1 = b();
        if(i1 == 1)
        {
            v.A = 3;
            v.d = true;
            v.j = 6;
            k = j1;
            return;
        }
        if(i1 == 2)
        {
            v.A = 3;
            v.d = true;
            v.j = 10;
            k = j1;
            return;
        }
        if(i1 == 3)
            if(j1 != 0)
            {
                v.k = 3;
                k = j1;
                return;
            } else
            {
                a();
                v.k = 3;
                return;
            }
        if(i1 == 4)
        {
            if(j1 != 0)
            {
                v.A = 3;
                v.d = true;
                v.j = 6;
                k = j1;
                return;
            }
            a();
            v.A = 3;
            v.d = true;
            v.j = 6;
        }
    }

    private static int a()
    {
        int i1 = -1;
        byte abyte0[];
        try
        {
            if((abyte0 = a(f_java_lang_String_static_fld, "register", (c_java_lang_String_static_fld == null || c_java_lang_String_static_fld.length() <= 0 ? "" : "&email=" + c_java_lang_String_static_fld) + (d_java_lang_String_static_fld == null || d_java_lang_String_static_fld.length() <= 0 ? "" : "&phone=" + d_java_lang_String_static_fld) + "&achievements=" + a(new String(a(v.a_byte_array1d_static_fld))), b_java_lang_String_static_fld)) != null)
            {
                DataInputStream datainputstream;
                if((i1 = (datainputstream = new DataInputStream(new ByteArrayInputStream(abyte0))).readInt()) == 0)
                {
                    v.a_k_array1d_static_fld[v.z].a_boolean_fld = true;
                    v.a_k_array1d_static_fld[v.z].c = new String(a_java_lang_String_static_fld);
                    v.a_k_array1d_static_fld[v.z].d = new String(b_java_lang_String_static_fld);
                    v.a_k_array1d_static_fld[v.z].b_boolean_fld = false;
                    v.e();
                    e_java_lang_String_static_fld = null;
                    try
                    {
                        a(datainputstream.readUTF());
                    }
                    catch(Exception _ex) { }
                }
                datainputstream.close();
            }
        }
        catch(Exception _ex) { }
        return i1;
    }

    private static int b()
    {
        int i1 = -1;
        String s;
        if((s = a(b_java_lang_String_static_fld, "auth")) == null)
            return -1;
        byte abyte0[];
        try
        {
            if((abyte0 = a(f_java_lang_String_static_fld, "auth", "&achievements=" + a(new String(a(v.a_byte_array1d_static_fld))) + "&get_achievements", s)) != null)
            {
                DataInputStream datainputstream;
                if((i1 = (datainputstream = new DataInputStream(new ByteArrayInputStream(abyte0))).readInt()) == 0)
                {
                    v.a_k_array1d_static_fld[v.z].a_boolean_fld = true;
                    v.a_k_array1d_static_fld[v.z].c = new String(a_java_lang_String_static_fld);
                    v.a_k_array1d_static_fld[v.z].d = new String(b_java_lang_String_static_fld);
                    v.a_k_array1d_static_fld[v.z].b_boolean_fld = false;
                    int j1;
                    if((j1 = datainputstream.readInt()) >= 18)
                    {
                        for(int k1 = 0; k1 < 18; k1++)
                            v.a_byte_array1d_static_fld[k1] = datainputstream.readByte();

                    } else
                    {
                        int l1 = 0;
                        do
                        {
                            if(l1 >= 18)
                                break;
                            if(v.a_byte_array1d_static_fld[l1] == 1)
                            {
                                v.a_k_array1d_static_fld[v.z].b_boolean_fld = true;
                                break;
                            }
                            l1++;
                        } while(true);
                    }
                    v.e();
                    e_java_lang_String_static_fld = null;
                    try
                    {
                        a(datainputstream.readUTF());
                    }
                    catch(Exception _ex) { }
                }
                datainputstream.close();
            }
        }
        catch(Exception _ex) { }
        return i1;
    }

    public static void a()
    {
        if(!v.a_k_array1d_static_fld[v.z].a_boolean_fld) goto _L2; else goto _L1
_L1:
        String s;
        if(e_java_lang_String_static_fld != null)
            s = a(a(e_java_lang_String_static_fld + v.a_k_array1d_static_fld[v.z].d));
        else
            s = a(v.a_k_array1d_static_fld[v.z].d, "submit_scores");
        if(s == null)
        {
            k = -1;
            return;
        }
        int i1;
        if((i1 = a(s)) != 12) goto _L4; else goto _L3
_L3:
        if((s = a(v.a_k_array1d_static_fld[v.z].d, "submit_scores")) == null)
        {
            k = i1;
            return;
        }
        a(s);
          goto _L4
_L2:
        a(((String) (null)));
        return;
        JVM INSTR dup ;
        Exception exception;
        exception;
        printStackTrace();
_L4:
    }

    private static int a(String s)
    {
        int i1;
        int ai[];
        i1 = -1;
        ai = null;
        byte abyte0[];
        ByteArrayOutputStream bytearrayoutputstream = new ByteArrayOutputStream();
        DataOutputStream dataoutputstream;
        (dataoutputstream = new DataOutputStream(bytearrayoutputstream)).writeInt(q);
        dataoutputstream.writeInt(r);
        dataoutputstream.writeUTF("scores");
        dataoutputstream.writeUTF(v.a_k_array1d_static_fld[v.z].a_boolean_fld ? v.a_k_array1d_static_fld[v.z].c : v.a_k_array1d_static_fld[v.z].a_java_lang_String_fld);
        dataoutputstream.writeInt(v.a_k_array1d_static_fld[v.z].a_int_fld);
        byte abyte1[];
        int k1;
        int l1;
        long l2;
        dataoutputstream.writeUTF("" + a_char_array1d_static_fld[k1 = (int)((l2 = a(abyte1 = a("scores" + r + (v.a_k_array1d_static_fld[v.z].a_boolean_fld ? v.a_k_array1d_static_fld[v.z].c : v.a_k_array1d_static_fld[v.z].a_java_lang_String_fld) + v.a_k_array1d_static_fld[v.z].a_int_fld))) % (long)a_char_array1d_static_fld.length)] + a_char_array1d_static_fld[l1 = (int)((l2 >> 9) % (long)a_char_array1d_static_fld.length)]);
        dataoutputstream.close();
        abyte0 = bytearrayoutputstream.toByteArray();
        if((s = a(f_java_lang_String_static_fld, "submit_scores", "&dat=" + a(new String(o.a(abyte0))), s)) == null) goto _L2; else goto _L1
_L1:
        if((i1 = (s = new DataInputStream(new ByteArrayInputStream(s))).readInt()) != 0) goto _L4; else goto _L3
_L3:
        ai = a(s.readUTF());
        e_java_lang_String_static_fld = null;
        try
        {
            a(s.readUTF());
        }
        catch(Exception _ex) { }
          goto _L4
        JVM INSTR dup ;
        Exception exception;
        exception;
        printStackTrace();
        s.close();
_L4:
        s.close();
          goto _L2
        JVM INSTR dup ;
        exception;
        printStackTrace();
_L2:
        if(i1 != 12)
            if(ai == null)
                i1 = 200;
            else
            if(ai[0] == -1)
            {
                i1 = 201;
            } else
            {
                i1 = 202;
                String s1;
                int j1;
                if((j1 = (s1 = o.a("er202_")).indexOf("%3%")) != -1)
                    s1 = s1.substring(0, j1) + (ai[3] <= 0 ? "-" : Integer.toString(ai[3])) + s1.substring(j1 + "%3%".length());
                if((j1 = s1.indexOf("%2%")) != -1)
                    s1 = s1.substring(0, j1) + (ai[2] <= 0 ? "-" : Integer.toString(ai[2])) + s1.substring(j1 + "%2%".length());
                if((j1 = s1.indexOf("%1%")) != -1)
                    s1 = s1.substring(0, j1) + (ai[1] <= 0 ? "-" : Integer.toString(ai[1])) + s1.substring(j1 + "%1%".length());
                o.a("er202", s1);
                v.a_k_array1d_static_fld[v.z].b_int_fld = ai[0];
                v.e();
            }
        k = i1;
        return i1;
    }

    public static void b()
    {
        int i1 = -1;
        Object obj;
        if(e_java_lang_String_static_fld != null)
            obj = a(a(e_java_lang_String_static_fld + v.a_k_array1d_static_fld[v.z].d));
        else
            obj = a(v.a_k_array1d_static_fld[v.z].d, "achievements");
        if(obj == null)
        {
            v.A = 3;
            v.d = true;
            v.j = 10;
            k = -1;
            return;
        }
        if((i1 = b(((String) (obj)))) != 12) goto _L2; else goto _L1
_L1:
        if((obj = a(v.a_k_array1d_static_fld[v.z].d, "achievements")) == null)
        {
            v.A = 3;
            v.d = true;
            v.j = 10;
            k = i1;
            return;
        }
        i1 = b(((String) (obj)));
          goto _L2
        JVM INSTR dup ;
        obj;
        printStackTrace();
_L2:
        v.A = 3;
        v.d = true;
        v.j = 10;
        k = i1;
        return;
    }

    private static int b(String s)
    {
        int i1 = -1;
        if((s = a(f_java_lang_String_static_fld, "achievements", "&achievements=" + a(new String(a(v.a_byte_array1d_static_fld))), s)) == null) goto _L2; else goto _L1
_L1:
        if((i1 = (s = new DataInputStream(new ByteArrayInputStream(s))).readInt()) != 0)
            break MISSING_BLOCK_LABEL_193;
        int j1;
        if((j1 = s.readInt()) >= 18)
        {
            for(int k1 = 0; k1 < 18; k1++)
                v.a_byte_array1d_static_fld[k1] = s.readByte();

            v.a_k_array1d_static_fld[v.z].b_boolean_fld = false;
        } else
        {
            int l1 = 0;
            do
            {
                if(l1 >= 18)
                    break;
                if(v.a_byte_array1d_static_fld[l1] == 1)
                {
                    v.a_k_array1d_static_fld[v.z].b_boolean_fld = true;
                    break;
                }
                l1++;
            } while(true);
        }
        v.e();
        e_java_lang_String_static_fld = null;
        try
        {
            a(s.readUTF());
        }
        catch(Exception _ex) { }
        break MISSING_BLOCK_LABEL_193;
        JVM INSTR dup ;
        Exception exception;
        exception;
        printStackTrace();
        s.close();
        return 11;
        s.close();
          goto _L2
        JVM INSTR dup ;
        s;
        printStackTrace();
_L2:
        return i1;
    }

    public static void c()
    {
        if(!v.a_k_array1d_static_fld[v.z].a_boolean_fld) goto _L2; else goto _L1
_L1:
        String s;
        if(e_java_lang_String_static_fld != null)
            s = a(a(e_java_lang_String_static_fld + v.a_k_array1d_static_fld[v.z].d));
        else
            s = a(v.a_k_array1d_static_fld[v.z].d, "get_scores");
        if(s == null)
        {
            k = -1;
            return;
        }
        int i1;
        if((i1 = c(s)) != 12) goto _L4; else goto _L3
_L3:
        if((s = a(v.a_k_array1d_static_fld[v.z].d, "get_scores")) == null)
        {
            k = i1;
            return;
        }
        c(s);
          goto _L4
_L2:
        c(null);
        return;
        JVM INSTR dup ;
        Exception exception;
        exception;
        printStackTrace();
_L4:
    }

    private static int c(String s)
    {
        int i1 = -1;
        if((s = a(f_java_lang_String_static_fld, "get_scores", "&top_offset=0&top_count=3&above_count=3&below_count=3&record_id=" + v.a_k_array1d_static_fld[v.z].b_int_fld + "&table_id=scores", s)) == null)
            break MISSING_BLOCK_LABEL_356;
        if((i1 = (s = new DataInputStream(new ByteArrayInputStream(s))).readInt()) != 0)
            break MISSING_BLOCK_LABEL_340;
        String s2;
        p = s.readInt();
        a_int_array1d_static_fld = null;
        a_java_lang_String_array1d_static_fld = null;
        b_int_array1d_static_fld = null;
        b_boolean_array1d_static_fld = null;
        a_int_array1d_static_fld = new int[p];
        a_java_lang_String_array1d_static_fld = new String[p];
        b_int_array1d_static_fld = new int[p];
        b_boolean_array1d_static_fld = new boolean[p];
        int j1 = 0;
        try
        {
            for(int k1 = 0; k1 < p; k1++)
            {
                String s1;
                int l1;
                s2 = s.readUTF();
                l1 = j1;
                s1 = s2;
                String as[] = o.a(s2, '|');
                a_int_array1d_static_fld[l1] = Integer.parseInt(as[0].substring(0, as[0].length() - 1));
                a_java_lang_String_array1d_static_fld[l1] = as[1].substring(0, as[1].length() - 1);
                b_int_array1d_static_fld[l1] = Integer.parseInt(as[2].substring(0, as[2].length() - 1));
                b_boolean_array1d_static_fld[l1] = as[3].indexOf('*') != -1;
                if(b_int_array1d_static_fld[l1] > 0)
                    j1++;
            }

            if(j1 > 0)
            {
                p = j1;
                e();
            } else
            {
                i1 = 200;
            }
        }
        catch(Exception _ex)
        {
            i1 = 200;
        }
        e_java_lang_String_static_fld = null;
        try
        {
            a(s.readUTF());
        }
        catch(Exception _ex) { }
        break MISSING_BLOCK_LABEL_340;
        JVM INSTR dup ;
        Exception exception;
        exception;
        printStackTrace();
        s.close();
        i1 = 200;
        s.close();
        break MISSING_BLOCK_LABEL_356;
        JVM INSTR dup ;
        s;
        printStackTrace();
        i1 = 200;
        k = i1;
        return i1;
    }

    private static void e()
    {
        a_java_util_Vector_static_fld.removeAllElements();
        int i1 = 0;
        int k1 = 0;
        int l1 = 0;
        a_int_static_fld = 0;
        b_int_static_fld = 0;
        c_int_static_fld = 0;
        for(int j2 = 0; j2 < p; j2++)
        {
            int i2;
            if((i2 = v.a_x_array1d_static_fld[0].a("" + a_int_array1d_static_fld[j2])) > k1)
                k1 = i2;
            if((i2 = v.a_x_array1d_static_fld[0].a("" + b_int_array1d_static_fld[j2])) > i1)
                i1 = i2;
            if((i2 = v.a_x_array1d_static_fld[0].a(a_java_lang_String_array1d_static_fld[j2])) > l1)
                l1 = i2;
        }

        if(l1 + i1 + k1 + 20 < u.h)
        {
            int k2 = u.h - 20 - k1 - i1 - l1 >> 2;
            c_int_static_fld = (b_int_static_fld = k2 + 10 + k1) + k2;
            a_int_static_fld = u.h - 10 - k2;
        } else
        {
            c_int_static_fld = (b_int_static_fld = k1 + 10) + 3;
            a_int_static_fld = u.h - 10;
            l1 = u.h - c_int_static_fld - i1 - 3 - 10;
        }
        for(int l2 = 0; l2 < p; l2++)
        {
            if(v.a_x_array1d_static_fld[0].a(a_java_lang_String_array1d_static_fld[l2]) <= l1)
            {
                a_java_util_Vector_static_fld.addElement(new w(a_int_array1d_static_fld[l2], a_java_lang_String_array1d_static_fld[l2], b_int_array1d_static_fld[l2], b_boolean_array1d_static_fld[l2]));
                continue;
            }
            c_java_util_Vector_static_fld.removeAllElements();
            c_java_util_Vector_static_fld = a(c_java_util_Vector_static_fld, a_java_lang_String_array1d_static_fld[l2], l1);
            a_java_util_Vector_static_fld.addElement(new w(a_int_array1d_static_fld[l2], (String)c_java_util_Vector_static_fld.elementAt(0), b_int_array1d_static_fld[l2], b_boolean_array1d_static_fld[l2]));
            if(c_java_util_Vector_static_fld.size() <= 1)
                continue;
            for(int j1 = 1; j1 < c_java_util_Vector_static_fld.size(); j1++)
                a_java_util_Vector_static_fld.addElement(new w(0, (String)c_java_util_Vector_static_fld.elementAt(j1), 0, b_boolean_array1d_static_fld[l2]));

        }

        if((d_int_static_fld = (u.i - 90) / 15) >= a_java_util_Vector_static_fld.size())
        {
            d_int_static_fld = a_java_util_Vector_static_fld.size();
            e_int_static_fld = 0;
            f_int_static_fld = u.i - d_int_static_fld * 15 >> 1;
            a_boolean_static_fld = false;
            return;
        } else
        {
            a_boolean_static_fld = true;
            e_int_static_fld = 0;
            f_int_static_fld = u.i - d_int_static_fld * 15 >> 1;
            return;
        }
    }

    private static Vector a(Vector vector, String s, int i1)
    {
        String s1 = "";
        boolean flag = false;
        int j1 = 0;
        int i2 = 0;
        int k1;
        for(; !flag; j1 = k1 + 1)
        {
            if((k1 = s.indexOf(' ', j1)) == -1)
            {
                k1 = s.length();
                flag = true;
            }
            String s2 = s.substring(j1, k1);
            int l1;
            if(i2 == 0)
                l1 = i2 + v.a_x_array1d_static_fld[0].a(s2);
            else
                l1 = i2 + v.a_x_array1d_static_fld[0].a(" " + s2);
            if(l1 <= i1)
            {
                if(i2 == 0)
                    s1 = s1 + s2;
                else
                    s1 = s1 + " " + s2;
                i2 = l1;
                if(!flag)
                    continue;
                if(s1.endsWith("`"))
                    s1 = s1.substring(0, s1.length() - 1) + "-";
                vector.addElement(s1);
                continue;
            }
            if(v.a_x_array1d_static_fld[0].a(s1) > 0)
            {
                if(s1.endsWith("`"))
                    s1 = s1.substring(0, s1.length() - 1) + "-";
                vector.addElement(s1);
            }
            if((l1 = v.a_x_array1d_static_fld[0].a(s2)) > i1)
            {
                while(l1 > i1) 
                {
                    if((s1 = s.substring(j1, k1)).startsWith("~") || s1.startsWith("^"))
                    {
                        j1++;
                        s1 = s.substring(j1, k1);
                    }
                    if(s1.lastIndexOf('~') != -1)
                        k1 = j1 + s1.lastIndexOf('~');
                    else
                    if(s1.lastIndexOf('^') != -1)
                    {
                        k1 = j1 + s1.lastIndexOf('^');
                        s = s.substring(0, k1) + "`" + s.substring(k1 + 1);
                        k1++;
                    } else
                    {
                        k1--;
                    }
                    s2 = s.substring(j1, k1);
                    l1 = v.a_x_array1d_static_fld[0].a(s2);
                    flag = false;
                }
                k1--;
            }
            s1 = s2;
            i2 = v.a_x_array1d_static_fld[0].a(s1);
            if(!flag)
                continue;
            if(s1.endsWith("`"))
                s1 = s1.substring(0, s1.length() - 1) + "-";
            vector.addElement(s1);
        }

        return vector;
    }

    public static void d()
    {
        b_java_util_Vector_static_fld.removeAllElements();
        int i1 = u.h - 20;
        String as[] = o.a(o.a("YCR_TXT"), '^');
        for(int j1 = 0; j1 < as.length; j1++)
            b_java_util_Vector_static_fld = a(b_java_util_Vector_static_fld, as[j1], i1);

        if((g_int_static_fld = (u.i - 90) / 15) >= b_java_util_Vector_static_fld.size())
        {
            g_int_static_fld = b_java_util_Vector_static_fld.size();
            h_int_static_fld = 0;
            i_int_static_fld = u.i - g_int_static_fld * 15 >> 1;
            b_boolean_static_fld = false;
            return;
        } else
        {
            b_boolean_static_fld = true;
            h_int_static_fld = 0;
            i_int_static_fld = u.i - g_int_static_fld * 15 >> 1;
            return;
        }
    }

    private static String a(String s, String s1)
    {
        String s2 = null;
        if((s1 = s1).equals("auth") || s1.equals("register"))
            s1 = a_java_lang_String_static_fld;
        else
            s1 = v.a_k_array1d_static_fld[v.z].c;
        s1 = "&login=" + a(s1);
        if((s1 = a(g_java_lang_String_static_fld, "POST", s1.getBytes())) != null)
        {
            s1 = new String(s1);
            s2 = a(a(s1 + s));
        }
        return s2;
    }

    public static final String a()
    {
        String s = i_java_lang_String_static_fld + "?top_count=1000" + "&record_id=" + v.a_k_array1d_static_fld[v.z].b_int_fld + "&table=scores" + "&game_id=" + o.a("gameID");
        if(v.a_k_array1d_static_fld[v.z].a_boolean_fld)
        {
            String s1 = null;
            try
            {
                s1 = a(v.a_k_array1d_static_fld[v.z].d, "url");
            }
            catch(Exception _ex) { }
            if(s1 != null)
                s = s + "&login=" + a(v.a_k_array1d_static_fld[v.z].c) + "&password=" + s1;
        }
        e_java_lang_String_static_fld = null;
        return s;
    }

    public static final String b()
    {
        String s = null;
        try
        {
            s = a(v.a_k_array1d_static_fld[v.z].d, "url");
        }
        catch(Exception _ex) { }
        e_java_lang_String_static_fld = null;
        if(s != null)
            return h_java_lang_String_static_fld + a(v.a_k_array1d_static_fld[v.z].c) + (s == null ? "/" : "/?app=1&password=" + s + "&login=" + a(v.a_k_array1d_static_fld[v.z].c));
        else
            return null;
    }

    private static byte[] a(String s, String s1, byte abyte0[])
    {
        byte abyte1[];
        HttpConnection httpconnection;
        DataInputStream datainputstream;
        abyte1 = null;
        httpconnection = null;
        datainputstream = null;
        (httpconnection = (HttpConnection)Connector.open(s, 3)).setRequestMethod(s1);
        if(s1 == "POST")
            httpconnection.setRequestProperty("Content-type", "application/x-www-form-urlencoded");
        httpconnection.setRequestProperty("Connection", "close");
        if(abyte0 != null)
        {
            (s = httpconnection.openDataOutputStream()).write(abyte0);
            s.close();
        }
        if(httpconnection.getResponseCode() == 200)
        {
            s = (int)httpconnection.getLength();
            datainputstream = httpconnection.openDataInputStream();
            if(s < 0)
            {
                s = new ByteArrayOutputStream();
                s1 = new DataOutputStream(s);
                while((abyte0 = datainputstream.read()) >= 0) 
                    s1.write(abyte0);
                abyte1 = s.toByteArray();
            } else
            if(s > 0)
            {
                abyte1 = new byte[s];
                datainputstream.readFully(abyte1);
            }
        }
        try
        {
            if(datainputstream != null)
                datainputstream.close();
            if(httpconnection != null)
                httpconnection.close();
        }
        catch(Exception _ex) { }
        break MISSING_BLOCK_LABEL_224;
        s;
        try
        {
            if(datainputstream != null)
                datainputstream.close();
            if(httpconnection != null)
                httpconnection.close();
        }
        catch(Exception _ex) { }
        throw s;
        return abyte1;
    }

    private static void a(String s)
    {
        if(s != null)
        {
            s = o.a(s, ';');
            for(int i1 = 0; i1 < s.length; i1++)
            {
                String as[];
                if((as = o.a(s[i1], ':')) == null || as.length != 2)
                    continue;
                if(as[0].trim().equals("user_id"))
                    as[1].trim();
                if(as[0].trim().equals("sess"))
                    e_java_lang_String_static_fld = as[1].trim();
            }

        }
    }

    private static int[] a(String s)
    {
        int ai[] = new int[4];
        if(s != null)
            if((s = o.a(s, '|')).length >= 4)
            {
                for(int i1 = 0; i1 < 4; i1++)
                    ai[i1] = Integer.parseInt(s[i1]);

            } else
            {
                ai = null;
            }
        return ai;
    }

    private static String a(String s)
    {
        if(s == null)
            return null;
        if(b_java_lang_String_array1d_static_fld == null)
        {
            String as[] = new String[256];
            StringBuffer stringbuffer1 = new StringBuffer();
            for(int j1 = 0; j1 < as.length; j1++)
            {
                stringbuffer1.setLength(0);
                stringbuffer1.append('%');
                stringbuffer1.append(j_java_lang_String_static_fld.charAt((j1 & 0xf0) >> 4));
                stringbuffer1.append(j_java_lang_String_static_fld.charAt(j1 & 0xf));
                as[j1] = stringbuffer1.toString();
            }

            b_java_lang_String_array1d_static_fld = as;
        }
        StringBuffer stringbuffer = new StringBuffer();
        int i1 = s.length();
        for(int k1 = 0; k1 < i1; k1++)
        {
            int l1 = s.charAt(k1);
            if(65 <= l1 && l1 <= 90)
            {
                stringbuffer.append((char)l1);
                continue;
            }
            if(97 <= l1 && l1 <= 122)
            {
                stringbuffer.append((char)l1);
                continue;
            }
            if(48 <= l1 && l1 <= 57)
            {
                stringbuffer.append((char)l1);
                continue;
            }
            if(l1 == 32)
            {
                stringbuffer.append('+');
                continue;
            }
            if(l1 == 45 || l1 == 95 || l1 == 46 || l1 == 33 || l1 == 126 || l1 == 42 || l1 == 39 || l1 == 40 || l1 == 41)
            {
                stringbuffer.append((char)l1);
                continue;
            }
            if(l1 <= 127)
            {
                stringbuffer.append(b_java_lang_String_array1d_static_fld[l1]);
                continue;
            }
            if(l1 <= 2047)
            {
                stringbuffer.append(b_java_lang_String_array1d_static_fld[0xc0 | l1 >> 6]);
                stringbuffer.append(b_java_lang_String_array1d_static_fld[0x80 | l1 & 0x3f]);
            } else
            {
                stringbuffer.append(b_java_lang_String_array1d_static_fld[0xe0 | l1 >> 12]);
                stringbuffer.append(b_java_lang_String_array1d_static_fld[0x80 | l1 >> 6 & 0x3f]);
                stringbuffer.append(b_java_lang_String_array1d_static_fld[0x80 | l1 & 0x3f]);
            }
        }

        return stringbuffer.toString();
    }

    private static byte[] a(String s, String s1, String s2, String s3)
    {
        String s4 = "&language=" + o.a("langID") + "&action=" + s1 + "&uid=" + j_int_static_fld + "&game_id=" + o.a("gameID");
        if(s3 != null)
        {
            if(s1.equals("auth") || s1.equals("register"))
                s1 = a_java_lang_String_static_fld;
            else
                s1 = v.a_k_array1d_static_fld[v.z].c;
            s4 = s4 + "&login=" + a(s1) + "&password=" + s3;
        }
        return a(s, "POST", (s4 + (s2 != null ? s2 : "")).getBytes());
    }

    private static String a(byte abyte0[])
    {
        long l1;
        abyte0 = (int)((l1 = a(abyte0)) % (long)a_char_array1d_static_fld.length);
        int i1 = (int)((l1 >> 9) % (long)a_char_array1d_static_fld.length);
        l1 = (int)((l1 >> 18) % (long)a_char_array1d_static_fld.length);
        return "" + a_char_array1d_static_fld[abyte0] + a_char_array1d_static_fld[i1] + a_char_array1d_static_fld[l1];
    }

    private static final long a(byte abyte0[])
    {
        int i1 = abyte0.length;
        abyte0 = 0;
        abyte0 = abyte0;
        if(c_int_array1d_static_fld == null)
        {
            c_int_array1d_static_fld = new int[256];
            for(int j1 = 0; j1 < 256; j1++)
            {
                int l1 = j1;
                for(int j2 = 0; j2 < 8; j2++)
                    if((l1 & 1) != 0)
                        l1 = 0xedb88320 ^ l1 >>> 1;
                    else
                        l1 >>>= 1;

                c_int_array1d_static_fld[j1] = l1;
            }

        }
        int k1 = -1;
        int i2 = i1 + 0;
        for(int k2 = 0; k2 < i2; k2++)
            k1 = c_int_array1d_static_fld[(k1 ^ abyte0[k2]) & 0xff] ^ k1 >>> 8;

        return (long)(~k1) & 0xffffffffL;
    }

    private static char[] a()
    {
        char ac[] = new char[64];
        int i1 = 0;
        for(char c1 = 'A'; c1 <= 'Z'; c1++)
            ac[i1++] = c1;

        for(char c2 = 'a'; c2 <= 'z'; c2++)
            ac[i1++] = c2;

        for(char c3 = '0'; c3 <= '9'; c3++)
            ac[i1++] = c3;

        ac[i1++] = '+';
        ac[i1] = '/';
        return ac;
    }

    private static char[] a(byte abyte0[])
    {
        int i1 = abyte0.length;
        abyte0 = abyte0;
        int j1 = ((i1 << 2) + 2) / 3;
        int k1;
        char ac[] = new char[k1 = (i1 + 2) / 3 << 2];
        int l1 = 0;
        for(int i2 = 0; l1 < i1; i2++)
        {
            int j2 = abyte0[l1++] & 0xff;
            int k2 = l1 >= i1 ? 0 : abyte0[l1++] & 0xff;
            int l2 = l1 >= i1 ? 0 : abyte0[l1++] & 0xff;
            int i3 = j2 >>> 2;
            j2 = (j2 & 3) << 4 | k2 >>> 4;
            k2 = (k2 & 0xf) << 2 | l2 >>> 6;
            l2 &= 0x3f;
            ac[i2++] = b_char_array1d_static_fld[i3];
            ac[i2++] = b_char_array1d_static_fld[j2];
            ac[i2] = i2 >= j1 ? '=' : b_char_array1d_static_fld[k2];
            i2++;
            ac[i2] = i2 >= j1 ? '=' : b_char_array1d_static_fld[l2];
        }

        return ac;
    }

    private static byte[] a(String s)
    {
        try
        {
            ByteArrayOutputStream bytearrayoutputstream = new ByteArrayOutputStream();
            DataOutputStream dataoutputstream;
            (dataoutputstream = new DataOutputStream(bytearrayoutputstream)).writeUTF(s);
            byte abyte0[];
            s = new byte[(abyte0 = bytearrayoutputstream.toByteArray()).length - 2];
            for(int i1 = 2; i1 < abyte0.length; i1++)
                s[i1 - 2] = abyte0[i1];

            bytearrayoutputstream.close();
            dataoutputstream.close();
        }
        catch(Exception _ex)
        {
            s = new byte[0];
        }
        return s;
    }

    public static Form a_javax_microedition_lcdui_Form_static_fld = null;
    private static Command a_javax_microedition_lcdui_Command_static_fld = null;
    private static Command b_javax_microedition_lcdui_Command_static_fld = null;
    private static volatile int l = 0;
    private static ChoiceGroup a_javax_microedition_lcdui_ChoiceGroup_static_fld = null;
    private static TextField a_javax_microedition_lcdui_TextField_static_fld = null;
    private static TextField b_javax_microedition_lcdui_TextField_static_fld = null;
    private static TextField c_javax_microedition_lcdui_TextField_static_fld = null;
    private static TextField d_javax_microedition_lcdui_TextField_static_fld = null;
    private static TextField e_javax_microedition_lcdui_TextField_static_fld = null;
    private static int m;
    private static int n;
    private static int o;
    private static boolean a_boolean_array1d_static_fld[] = new boolean[1];
    private static String a_java_lang_String_static_fld;
    private static String b_java_lang_String_static_fld;
    private static String c_java_lang_String_static_fld;
    private static String d_java_lang_String_static_fld;
    private static boolean c_boolean_static_fld;
    public static Vector a_java_util_Vector_static_fld = new Vector();
    private static Vector c_java_util_Vector_static_fld = new Vector();
    public static int a_int_static_fld = 0;
    public static int b_int_static_fld = 0;
    public static int c_int_static_fld = 0;
    public static int d_int_static_fld = 0;
    public static int e_int_static_fld = 0;
    public static int f_int_static_fld = 0;
    public static boolean a_boolean_static_fld = false;
    private static int p = 0;
    private static int a_int_array1d_static_fld[];
    private static String a_java_lang_String_array1d_static_fld[];
    private static int b_int_array1d_static_fld[];
    private static boolean b_boolean_array1d_static_fld[];
    public static Vector b_java_util_Vector_static_fld = new Vector();
    public static int g_int_static_fld = 0;
    public static int h_int_static_fld = 0;
    public static int i_int_static_fld = 0;
    public static boolean b_boolean_static_fld = false;
    private static int q = 1;
    private static int r = 196;
    public static int j_int_static_fld = 0;
    public static int k = -1;
    private static String e_java_lang_String_static_fld = null;
    private static String f_java_lang_String_static_fld = "http://wap.herocraft.com/users/api";
    private static String g_java_lang_String_static_fld = "http://wap.herocraft.com/api/get_session";
    private static String h_java_lang_String_static_fld = "http://wap.herocraft.com/heroes/";
    private static String i_java_lang_String_static_fld = "http://wap.herocraft.com/get_scores";
    private static String b_java_lang_String_array1d_static_fld[] = null;
    private static String j_java_lang_String_static_fld = "0123456789ABCDEF";
    private static final char a_char_array1d_static_fld[] = {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
        'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 
        'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 
        'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 
        'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 
        'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', 
        '8', '9'
    };
    private static int c_int_array1d_static_fld[];
    private static char b_char_array1d_static_fld[] = a();

}
