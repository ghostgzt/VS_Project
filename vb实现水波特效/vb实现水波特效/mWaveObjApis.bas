Attribute VB_Name = "mWaveObjApis"
'*************************************************************************
'**ģ �� ����mWaveObjApis
'**˵    ����WaterEx.dll������������
'**�� �� �ˣ��·�
'**��    ����WaterEx.dll�ɹ·���д���������Ʊ�ʵ��ˮ����Ч�Ĵ�������
'**��    ����V1.0.0
'*************************************************************************

'1������ˮ������>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
'   Ҫ��һ�����ڽ��л滭������Ҫ����һ��ˮ�����󣨱���������һЩ��������
'      hWnd --> Ҫ�滭ˮ��Ч���Ĵ��ڣ���Ⱦ���ͼƬ���������ڵĿͻ�����
'      hBmp --> ����ͼƬ���滭�ķ�Χ��Сͬ����ͼƬ��С
'      dwTime --> ˢ�µ�ʱ���������룩������ֵ��10��30
'      dwType --> =0 ��ʾԲ��ˮ����=1��ʾ��Բ��ˮ��������͸��Ч����
'      ����ֵ�� 0���ɹ������󱻳�ʼ������1��ʧ�ܣ�
Public Enum WaveShape
    sRound   'Բ��ˮ��
    sEllipse '��Բ��ˮ��
End Enum
Declare Function WaveInit Lib "WaterEx.dll" Alias "_WaveInit" _
        (ByVal HWND&, ByVal hBmp&, ByVal dwSpeed&, ByVal dwType As WaveShape) As Long

'2��>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
'��1. �Զ���ʾ��Ч
' --> ���꣬dwParam1���ܼ��ٶȣ�0���ܣ�Խ��Խϡ�裩������ֵ��0��30
'           dwParam2��������ֱ��������ֵ��0��5
'           dwParam3������������������ֵ��50��250
' --> ��ͧ��dwParam1���ٶȣ�0������Խ��Խ�죩������ֵ��0��8
'           dwParam2������С������ֵ��0��4
'           dwParam3��ˮ����ɢ�ķ�Χ������ֵ��100��500
' --> ���ˣ�dwParam1���ܶȣ�Խ��Խ�ܣ�������ֵ��50��300
'           dwParam2����С������ֵ��2��5
'           dwParam3������������ֵ��5��10
Public Enum WaveType
    wClose  '�ر���Ч
    wrain   '����
    wlaunch '��ͧ
    wWaves  '����
End Enum
Declare Sub WaveEffect Lib "WaterEx.dll" Alias "_WaveEffect" _
        (ByVal dwType As WaveType, ByVal dwParam1&, ByVal dwParam2&, ByVal dwParam3&)

'��2.��ָ��λ�á���ʯͷ��������ˮ��
'         dwPosX,dwPosY --> ����ʯͷ��λ��
'         dwStoneSize --> ʯͷ�Ĵ�С������ʼ��Ĵ�С������ֵ��0��5
'         dwStoneWeight --> ʯͷ�������������˲������ɢ�ķ�Χ��С������ֵ��10��1000
Declare Sub WaveDropStone Lib "WaterEx.dll" Alias "_WaveDropStone" _
        (ByVal dwX&, ByVal dwY&, ByVal dwSize&, ByVal dwWeight&)


'�� ���ڿͻ���ǿ�Ƹ���
Declare Sub WaveUpdateFrame Lib "WaterEx.dll" Alias "_WaveUpdateFrame" (ByVal bIfForce As Boolean)


'3�� �ͷ�ˮ������(��dll��ж��ʱ���Զ����øú���)
Declare Sub WaveFree Lib "WaterEx.dll" Alias "_WaveFree" ()
