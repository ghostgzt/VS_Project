 


public final class n
{

    public n()
    {
    }

    public final void a(String s)
    {
        if(s == null)
        {
            a = null;
            return;
        }
        StringBuffer stringbuffer = new StringBuffer("");
        for(int i = 0; i < s.length(); i++)
        {
            char c;
            if((c = s.charAt(i)) != '\r' && c != '\n')
                stringbuffer.append(c);
        }

        a = stringbuffer.toString();
    }

    public final int a(int i)
    {
        if(i > 0)
        {
            int j;
            if((j = (b * 100) / i) < 0)
                j = 0;
            if(j > 100)
                j = 100;
            return j;
        } else
        {
            return 0;
        }
    }

    public String a;
    public int b;
}
