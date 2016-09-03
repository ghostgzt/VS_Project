 

import javax.microedition.lcdui.Display;
import javax.microedition.midlet.MIDlet;

public class gameMIDlet extends MIDlet
{

    public gameMIDlet()
    {
        a_gameMIDlet_static_fld = this;
        a_v_static_fld = new v(this);
    }

    public void startApp()
    {
        if(a_boolean_static_fld)
        {
            if((a_java_lang_String_static_fld = getAppProperty("MIDlet-Version")) == null)
                a_java_lang_String_static_fld = "1.0";
            a_boolean_static_fld = false;
            Display.getDisplay(this).setCurrent(a_v_static_fld);
        }
        if(a_int_static_fld != -1)
            switch(a_int_static_fld)
            {
            case 2: // '\002'
                Display.getDisplay(this).setCurrent(t.a);
                break;

            case 3: // '\003'
                Display.getDisplay(this).setCurrent(a_v_static_fld.a_javax_microedition_lcdui_TextBox_fld);
                break;

            default:
                Display.getDisplay(this).setCurrent(a_v_static_fld);
                break;
            }
        a_v_static_fld.c();
    }

    public void pauseApp()
    {
        a_v_static_fld.d();
        notifyPaused();
    }

    public void destroyApp(boolean flag)
    {
        if(j.b < 0L)
            a_v_static_fld.b();
        if(v.a_q_static_fld != null)
        {
            v.a_q_static_fld.a();
            v.a_q_static_fld.b();
        }
        v.a_q_static_fld = null;
        System.gc();
        try
        {
            notifyDestroyed();
            return;
        }
        catch(Exception _ex)
        {
            return;
        }
    }

    public static int a_int_static_fld = 1;
    public static String a_java_lang_String_static_fld;
    private static boolean a_boolean_static_fld = true;
    public static gameMIDlet a_gameMIDlet_static_fld;
    public static v a_v_static_fld;

}
