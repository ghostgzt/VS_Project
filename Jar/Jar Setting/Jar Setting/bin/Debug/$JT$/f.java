 

import java.io.PrintStream;
import java.util.Vector;

public final class f
{

    public f()
    {
        a = "";
        b = "";
        c = "";
        d = new Vector();
    }

    final void a(String s)
    {
        a = "";
        b = "";
        c = "";
        d = new Vector();
        if(s == null)
            return;
        if(s.length() == 0)
            return;
        int i = 0;
        boolean flag = false;
        for(int j = 0; j < s.length(); j++)
        {
            String s1 = null;
            if(s.charAt(j) == '\n')
            {
                s1 = s.substring(i, j);
            } else
            {
                if(j != s.length() - 1)
                    continue;
                s1 = s.substring(i, j + 1);
            }
            i = j + 1;
            if(s1.startsWith("巧记:"))
            {
                a = s1.substring(3, s1.length());
                continue;
            }
            if(s1.startsWith("同义词:"))
            {
                b = s1.substring(4, s1.length());
                continue;
            }
            if(s1.startsWith("反义词:"))
            {
                c = s1.substring(4, s1.length());
                continue;
            }
            if(s1.startsWith("例句:"))
            {
                flag = true;
                continue;
            }
            int k;
            if(flag)
            {
                if(Character.isDigit(s1.charAt(0)))
                {
                    if((k = s1.indexOf(".")) < 0)
                        d.addElement(s1);
                    else
                        d.addElement(s1.substring(k + 1, s1.length()));
                } else
                {
                    d.addElement(s1);
                }
            } else
            {
                System.out.println("Error: Example " + s1);
            }
        }

    }

    String a;
    String b;
    String c;
    Vector d;
}
