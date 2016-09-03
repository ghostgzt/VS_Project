 

import javax.microedition.rms.RecordStore;
import javax.microedition.rms.RecordStoreException;

public final class o
{

    public o()
    {
        a = 0;
        b = null;
    }

    public static final void a()
    {
        try
        {
            byte abyte0[] = (new String(b + "," + a)).getBytes();
            RecordStore recordstore;
            if((recordstore = RecordStore.openRecordStore("ExitPosition", true)).getNumRecords() >= 1)
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

    public static final void b()
    {
        RecordStore recordstore;
        try
        {
            if((recordstore = RecordStore.openRecordStore("ExitPosition", true)).getNumRecords() >= 1)
            {
                byte abyte0[] = recordstore.getRecord(1);
                recordstore.closeRecordStore();
                String s;
                int i;
                if((i = (s = new String(abyte0)).indexOf(',')) != -1)
                {
                    b = s.substring(0, i);
                    a = Integer.parseInt(s.substring(i + 1, abyte0.length));
                    return;
                } else
                {
                    b = null;
                    a = 0;
                    return;
                }
            }
        }
        catch(RecordStoreException _ex)
        {
            a = 0;
            b = null;
        }
    }

    public static int a;
    public static String b;
}
