 

import javax.microedition.lcdui.*;
import javax.microedition.rms.RecordStore;
import javax.microedition.rms.RecordStoreException;

public final class m
    implements CommandListener, ItemStateListener
{

    public m()
    {
    }

    public final void a(Display display)
    {
        byte byte0;
        if(JavaBook.d)
            byte0 = 4;
        else
            byte0 = 1;
        i = display;
        j = i.getCurrent();
        String as[] = {
            "中", "小", "大"
        };
        String as1[] = {
            "置右", "置顶", "无"
        };
        f = new Form("设置:");
        a = new Gauge("背景色:" + h[g.c], true, 7, g.c);
        b = new Gauge("字体色:" + g[g.d], true, 15, g.d);
        c = new ChoiceGroup("字体大小", byte0, as, null);
        d = new ChoiceGroup("进度条位置", byte0, as1, null);
        f.append(a);
        f.append(b);
        f.append(c);
        f.append(d);
        c.setSelectedIndex(g.e, true);
        if(g.f == 1)
            d.setSelectedIndex(1, true);
        else
        if(g.f == 0)
            d.setSelectedIndex(0, true);
        else
            d.setSelectedIndex(2, true);
        e = new Command("应用", 1, 1);
        k = new Command("返回", 2, 1);
        f.addCommand(e);
        f.addCommand(k);
        f.setCommandListener(this);
        f.setItemStateListener(this);
        i.setCurrent(f);
    }

    public final void a()
    {
        try
        {
            byte abyte0[] = (new String(g.c + "/" + g.d + "/" + g.e + "/" + g.f + "/" + g.h + "/" + g.g)).getBytes();
            RecordStore recordstore;
            if((recordstore = RecordStore.openRecordStore("Option", true)).getNumRecords() >= 1)
                recordstore.setRecord(1, abyte0, 0, abyte0.length);
            else
                recordstore.addRecord(abyte0, 0, abyte0.length);
            recordstore.closeRecordStore();
            return;
        }
        catch(RecordStoreException _ex)
        {
            return;
        }
    }

    public final void commandAction(Command command, Displayable displayable)
    {
        if(command == k)
        {
            i.setCurrent(j);
            f = null;
            a = null;
            b = null;
            c = null;
            d = null;
            e = null;
            System.gc();
            return;
        }
        if(command == e)
        {
            f.setTitle("请稍候...");
            a a1 = new a();
            g.c = a.getValue();
            g.d = b.getValue();
            g.e = c.getSelectedIndex();
            g.f = d.getSelectedIndex();
            a();
            f = null;
            a = null;
            b = null;
            c = null;
            d = null;
            e = null;
            System.gc();
            a1.a(i, JavaBook.f);
        }
    }

    public final void itemStateChanged(Item item)
    {
        if(item == a)
            a.setLabel("背景色:" + h[a.getValue()]);
        if(item == b)
            b.setLabel("字体色:" + g[b.getValue()]);
    }

    private Gauge a;
    private Gauge b;
    private ChoiceGroup c;
    private ChoiceGroup d;
    private Command e;
    private Form f;
    private String g[] = {
        "白", "黑", "暗灰", "亮灰", "暗绿", "亮绿", "暗蓝", "亮蓝", "暗红", "亮红", 
        "暗青", "天青", "暗黄", "亮黄", "暗紫", "亮紫"
    };
    private String h[] = {
        "白", "黑", "暗灰", "暗绿", "暗蓝", "暗红", "暗青", "暗黄"
    };
    private Display i;
    private Displayable j;
    private Command k;
}
