 


final class e extends Thread
{

    e(MemoDictMIDlet memodictmidlet, s s1)
    {
        d = memodictmidlet;
        c = s1;
        b = false;
    }

    public final void run()
    {
        b = true;
        try
        {
            do
            {
                MemoDictMIDlet.w = 0;
                c.a(a);
                if(!MemoDictMIDlet.H)
                    break;
                MemoDictMIDlet.H = false;
            } while(true);
            MemoDictMIDlet.d(d, MemoDictMIDlet.x);
            MemoDictMIDlet.D(MemoDictMIDlet.i(d).f(MemoDictMIDlet.i(d).q()));
            MemoDictMIDlet.v.e();
            MemoDictMIDlet.v.repaint();
        }
        catch(Exception _ex) { }
        b = false;
    }

    private s c;
    String a;
    boolean b;
    private final MemoDictMIDlet d;
}
