 


public final class ag
{

    public ag(String s, String s1)
    {
        a = s;
        b = s1;
        c = 0;
        d = "";
    }

    public final void a(String s, String s1)
    {
        s = "<" + s + "=";
        int i = d.indexOf(s);
        int j = d.indexOf(">", i + s.length());
        if(i >= 0)
        {
            d = d.substring(0, i + s.length()) + s1 + d.substring(j, d.length());
            return;
        } else
        {
            d += s + s1 + ">";
            return;
        }
    }

    public final String a(String s)
    {
        if((this = a.a(d, "<" + s + "=>")) == null)
            return "";
        else
            return this;
    }

    String a;
    String b;
    byte c;
    String d;
}
