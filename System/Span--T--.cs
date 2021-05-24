[IsReadOnlyAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[DefaultMemberAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[IsByRefLikeAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[DebuggerTypeProxyAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[DebuggerDisplayAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[DebuggerTypeProxyAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[DebuggerDisplayAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
[ObsoleteAttribute] // RVA: 0x1289C0 Offset: 0x128AC1 VA: 0x1289C0
public struct Span<T> // TypeDefIndex: 4382
{
	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCA0 Offset: 0x35CDA1 VA: 0x35CCA0
	|-Span<byte>.get_Length
	|
	|-RVA: 0x35D1A0 Offset: 0x35D2A1 VA: 0x35D1A0
	|-Span<char>.get_Length
	|
	|-RVA: 0x35D650 Offset: 0x35D751 VA: 0x35D650
	|-Span<double>.get_Length
	|
	|-RVA: 0x35DB00 Offset: 0x35DC01 VA: 0x35DB00
	|-Span<int>.get_Length
	|
	|-RVA: 0x35DFB0 Offset: 0x35E0B1 VA: 0x35DFB0
	|-Span<long>.get_Length
	|
	|-RVA: 0x35E460 Offset: 0x35E561 VA: 0x35E460
	|-Span<object>.get_Length
	|
	|-RVA: 0x35E960 Offset: 0x35EA61 VA: 0x35E960
	|-Span<float>.get_Length
	|
	|-RVA: 0x35EE10 Offset: 0x35EF11 VA: 0x35EE10
	|-Span<ushort>.get_Length
	|
	|-RVA: 0x35F2C0 Offset: 0x35F3C1 VA: 0x35F2C0
	|-Span<uint>.get_Length
	|
	|-RVA: 0x35F770 Offset: 0x35F871 VA: 0x35F770
	|-Span<Bounds>.get_Length
	|
	|-RVA: 0x35FC20 Offset: 0x35FD21 VA: 0x35FC20
	|-Span<Color>.get_Length
	|
	|-RVA: 0x3600D0 Offset: 0x3601D1 VA: 0x3600D0
	|-Span<Quaternion>.get_Length
	|
	|-RVA: 0x360580 Offset: 0x360681 VA: 0x360580
	|-Span<Rect>.get_Length
	|
	|-RVA: 0x360A30 Offset: 0x360B31 VA: 0x360A30
	|-Span<Vector2>.get_Length
	|
	|-RVA: 0x360EE0 Offset: 0x360FE1 VA: 0x360EE0
	|-Span<Vector3>.get_Length
	|
	|-RVA: 0x382F20 Offset: 0x383021 VA: 0x382F20
	|-Span<Vector4>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0x128EC0 Offset: 0x128FC1 VA: 0x128EC0
	[EditorBrowsableAttribute] // RVA: 0x128EC0 Offset: 0x128FC1 VA: 0x128EC0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCB0 Offset: 0x35CDB1 VA: 0x35CCB0
	|-Span<byte>.Equals
	|
	|-RVA: 0x35D1B0 Offset: 0x35D2B1 VA: 0x35D1B0
	|-Span<char>.Equals
	|
	|-RVA: 0x35D660 Offset: 0x35D761 VA: 0x35D660
	|-Span<double>.Equals
	|
	|-RVA: 0x35DB10 Offset: 0x35DC11 VA: 0x35DB10
	|-Span<int>.Equals
	|
	|-RVA: 0x35DFC0 Offset: 0x35E0C1 VA: 0x35DFC0
	|-Span<long>.Equals
	|
	|-RVA: 0x35E470 Offset: 0x35E571 VA: 0x35E470
	|-Span<object>.Equals
	|
	|-RVA: 0x35E970 Offset: 0x35EA71 VA: 0x35E970
	|-Span<float>.Equals
	|
	|-RVA: 0x35EE20 Offset: 0x35EF21 VA: 0x35EE20
	|-Span<ushort>.Equals
	|
	|-RVA: 0x35F2D0 Offset: 0x35F3D1 VA: 0x35F2D0
	|-Span<uint>.Equals
	|
	|-RVA: 0x35F780 Offset: 0x35F881 VA: 0x35F780
	|-Span<Bounds>.Equals
	|
	|-RVA: 0x35FC30 Offset: 0x35FD31 VA: 0x35FC30
	|-Span<Color>.Equals
	|
	|-RVA: 0x3600E0 Offset: 0x3601E1 VA: 0x3600E0
	|-Span<Quaternion>.Equals
	|
	|-RVA: 0x360590 Offset: 0x360691 VA: 0x360590
	|-Span<Rect>.Equals
	|
	|-RVA: 0x360A40 Offset: 0x360B41 VA: 0x360A40
	|-Span<Vector2>.Equals
	|
	|-RVA: 0x360EF0 Offset: 0x360FF1 VA: 0x360EF0
	|-Span<Vector3>.Equals
	|
	|-RVA: 0x382F30 Offset: 0x383031 VA: 0x382F30
	|-Span<Vector4>.Equals
	*/

	[EditorBrowsableAttribute] // RVA: 0x128F10 Offset: 0x129011 VA: 0x128F10
	[ObsoleteAttribute] // RVA: 0x128F10 Offset: 0x129011 VA: 0x128F10
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCC0 Offset: 0x35CDC1 VA: 0x35CCC0
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x35D1C0 Offset: 0x35D2C1 VA: 0x35D1C0
	|-Span<char>.GetHashCode
	|
	|-RVA: 0x35D670 Offset: 0x35D771 VA: 0x35D670
	|-Span<double>.GetHashCode
	|
	|-RVA: 0x35DB20 Offset: 0x35DC21 VA: 0x35DB20
	|-Span<int>.GetHashCode
	|
	|-RVA: 0x35DFD0 Offset: 0x35E0D1 VA: 0x35DFD0
	|-Span<long>.GetHashCode
	|
	|-RVA: 0x35E480 Offset: 0x35E581 VA: 0x35E480
	|-Span<object>.GetHashCode
	|
	|-RVA: 0x35E980 Offset: 0x35EA81 VA: 0x35E980
	|-Span<float>.GetHashCode
	|
	|-RVA: 0x35EE30 Offset: 0x35EF31 VA: 0x35EE30
	|-Span<ushort>.GetHashCode
	|
	|-RVA: 0x35F2E0 Offset: 0x35F3E1 VA: 0x35F2E0
	|-Span<uint>.GetHashCode
	|
	|-RVA: 0x35F790 Offset: 0x35F891 VA: 0x35F790
	|-Span<Bounds>.GetHashCode
	|
	|-RVA: 0x35FC40 Offset: 0x35FD41 VA: 0x35FC40
	|-Span<Color>.GetHashCode
	|
	|-RVA: 0x3600F0 Offset: 0x3601F1 VA: 0x3600F0
	|-Span<Quaternion>.GetHashCode
	|
	|-RVA: 0x3605A0 Offset: 0x3606A1 VA: 0x3605A0
	|-Span<Rect>.GetHashCode
	|
	|-RVA: 0x360A50 Offset: 0x360B51 VA: 0x360A50
	|-Span<Vector2>.GetHashCode
	|
	|-RVA: 0x360F00 Offset: 0x361001 VA: 0x360F00
	|-Span<Vector3>.GetHashCode
	|
	|-RVA: 0x382F40 Offset: 0x383041 VA: 0x382F40
	|-Span<Vector4>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2682070 Offset: 0x2682171 VA: 0x2682070
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x2683D50 Offset: 0x2683E51 VA: 0x2683D50
	|-Span<char>.op_Implicit
	|
	|-RVA: 0x26855A0 Offset: 0x26856A1 VA: 0x26855A0
	|-Span<double>.op_Implicit
	|
	|-RVA: 0x2686DF0 Offset: 0x2686EF1 VA: 0x2686DF0
	|-Span<int>.op_Implicit
	|
	|-RVA: 0x2688640 Offset: 0x2688741 VA: 0x2688640
	|-Span<long>.op_Implicit
	|
	|-RVA: 0x2689E90 Offset: 0x2689F91 VA: 0x2689E90
	|-Span<object>.op_Implicit
	|
	|-RVA: 0x268BD20 Offset: 0x268BE21 VA: 0x268BD20
	|-Span<float>.op_Implicit
	|
	|-RVA: 0x268D570 Offset: 0x268D671 VA: 0x268D570
	|-Span<ushort>.op_Implicit
	|
	|-RVA: 0x268EDC0 Offset: 0x268EEC1 VA: 0x268EDC0
	|-Span<uint>.op_Implicit
	|
	|-RVA: 0x2690610 Offset: 0x2690711 VA: 0x2690610
	|-Span<Bounds>.op_Implicit
	|
	|-RVA: 0x2691E60 Offset: 0x2691F61 VA: 0x2691E60
	|-Span<Color>.op_Implicit
	|
	|-RVA: 0x26936B0 Offset: 0x26937B1 VA: 0x26936B0
	|-Span<Quaternion>.op_Implicit
	|
	|-RVA: 0x2694F00 Offset: 0x2695001 VA: 0x2694F00
	|-Span<Rect>.op_Implicit
	|
	|-RVA: 0x2696750 Offset: 0x2696851 VA: 0x2696750
	|-Span<Vector2>.op_Implicit
	|
	|-RVA: 0x2697FA0 Offset: 0x26980A1 VA: 0x2697FA0
	|-Span<Vector3>.op_Implicit
	|
	|-RVA: 0x2B81CF0 Offset: 0x2B81DF1 VA: 0x2B81CF0
	|-Span<Vector4>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCD0 Offset: 0x35CDD1 VA: 0x35CCD0
	|-Span<byte>..ctor
	|
	|-RVA: 0x35D1D0 Offset: 0x35D2D1 VA: 0x35D1D0
	|-Span<char>..ctor
	|
	|-RVA: 0x35D680 Offset: 0x35D781 VA: 0x35D680
	|-Span<double>..ctor
	|
	|-RVA: 0x35DB30 Offset: 0x35DC31 VA: 0x35DB30
	|-Span<int>..ctor
	|
	|-RVA: 0x35DFE0 Offset: 0x35E0E1 VA: 0x35DFE0
	|-Span<long>..ctor
	|
	|-RVA: 0x35E490 Offset: 0x35E591 VA: 0x35E490
	|-Span<object>..ctor
	|
	|-RVA: 0x35E990 Offset: 0x35EA91 VA: 0x35E990
	|-Span<float>..ctor
	|
	|-RVA: 0x35EE40 Offset: 0x35EF41 VA: 0x35EE40
	|-Span<ushort>..ctor
	|
	|-RVA: 0x35F2F0 Offset: 0x35F3F1 VA: 0x35F2F0
	|-Span<uint>..ctor
	|
	|-RVA: 0x35F7A0 Offset: 0x35F8A1 VA: 0x35F7A0
	|-Span<Bounds>..ctor
	|
	|-RVA: 0x35FC50 Offset: 0x35FD51 VA: 0x35FC50
	|-Span<Color>..ctor
	|
	|-RVA: 0x360100 Offset: 0x360201 VA: 0x360100
	|-Span<Quaternion>..ctor
	|
	|-RVA: 0x3605B0 Offset: 0x3606B1 VA: 0x3605B0
	|-Span<Rect>..ctor
	|
	|-RVA: 0x360A60 Offset: 0x360B61 VA: 0x360A60
	|-Span<Vector2>..ctor
	|
	|-RVA: 0x360F10 Offset: 0x361011 VA: 0x360F10
	|-Span<Vector3>..ctor
	|
	|-RVA: 0x382F50 Offset: 0x383051 VA: 0x382F50
	|-Span<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCE0 Offset: 0x35CDE1 VA: 0x35CCE0
	|-Span<byte>..ctor
	|
	|-RVA: 0x35D1E0 Offset: 0x35D2E1 VA: 0x35D1E0
	|-Span<char>..ctor
	|
	|-RVA: 0x35D690 Offset: 0x35D791 VA: 0x35D690
	|-Span<double>..ctor
	|
	|-RVA: 0x35DB40 Offset: 0x35DC41 VA: 0x35DB40
	|-Span<int>..ctor
	|
	|-RVA: 0x35DFF0 Offset: 0x35E0F1 VA: 0x35DFF0
	|-Span<long>..ctor
	|
	|-RVA: 0x35E4A0 Offset: 0x35E5A1 VA: 0x35E4A0
	|-Span<object>..ctor
	|
	|-RVA: 0x35E9A0 Offset: 0x35EAA1 VA: 0x35E9A0
	|-Span<float>..ctor
	|
	|-RVA: 0x35EE50 Offset: 0x35EF51 VA: 0x35EE50
	|-Span<ushort>..ctor
	|
	|-RVA: 0x35F300 Offset: 0x35F401 VA: 0x35F300
	|-Span<uint>..ctor
	|
	|-RVA: 0x35F7B0 Offset: 0x35F8B1 VA: 0x35F7B0
	|-Span<Bounds>..ctor
	|
	|-RVA: 0x35FC60 Offset: 0x35FD61 VA: 0x35FC60
	|-Span<Color>..ctor
	|
	|-RVA: 0x360110 Offset: 0x360211 VA: 0x360110
	|-Span<Quaternion>..ctor
	|
	|-RVA: 0x3605C0 Offset: 0x3606C1 VA: 0x3605C0
	|-Span<Rect>..ctor
	|
	|-RVA: 0x360A70 Offset: 0x360B71 VA: 0x360A70
	|-Span<Vector2>..ctor
	|
	|-RVA: 0x360F20 Offset: 0x361021 VA: 0x360F20
	|-Span<Vector3>..ctor
	|
	|-RVA: 0x382F60 Offset: 0x383061 VA: 0x382F60
	|-Span<Vector4>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x128F60 Offset: 0x129061 VA: 0x128F60
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CCF0 Offset: 0x35CDF1 VA: 0x35CCF0
	|-Span<byte>..ctor
	|
	|-RVA: 0x35D1F0 Offset: 0x35D2F1 VA: 0x35D1F0
	|-Span<char>..ctor
	|
	|-RVA: 0x35D6A0 Offset: 0x35D7A1 VA: 0x35D6A0
	|-Span<double>..ctor
	|
	|-RVA: 0x35DB50 Offset: 0x35DC51 VA: 0x35DB50
	|-Span<int>..ctor
	|
	|-RVA: 0x35E000 Offset: 0x35E101 VA: 0x35E000
	|-Span<long>..ctor
	|
	|-RVA: 0x35E4B0 Offset: 0x35E5B1 VA: 0x35E4B0
	|-Span<object>..ctor
	|
	|-RVA: 0x35E9B0 Offset: 0x35EAB1 VA: 0x35E9B0
	|-Span<float>..ctor
	|
	|-RVA: 0x35EE60 Offset: 0x35EF61 VA: 0x35EE60
	|-Span<ushort>..ctor
	|
	|-RVA: 0x35F310 Offset: 0x35F411 VA: 0x35F310
	|-Span<uint>..ctor
	|
	|-RVA: 0x35F7C0 Offset: 0x35F8C1 VA: 0x35F7C0
	|-Span<Bounds>..ctor
	|
	|-RVA: 0x35FC70 Offset: 0x35FD71 VA: 0x35FC70
	|-Span<Color>..ctor
	|
	|-RVA: 0x360120 Offset: 0x360221 VA: 0x360120
	|-Span<Quaternion>..ctor
	|
	|-RVA: 0x3605D0 Offset: 0x3606D1 VA: 0x3605D0
	|-Span<Rect>..ctor
	|
	|-RVA: 0x360A80 Offset: 0x360B81 VA: 0x360A80
	|-Span<Vector2>..ctor
	|
	|-RVA: 0x360F30 Offset: 0x361031 VA: 0x360F30
	|-Span<Vector3>..ctor
	|
	|-RVA: 0x382F70 Offset: 0x383071 VA: 0x382F70
	|-Span<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CD00 Offset: 0x35CE01 VA: 0x35CD00
	|-Span<byte>..ctor
	|
	|-RVA: 0x35D200 Offset: 0x35D301 VA: 0x35D200
	|-Span<char>..ctor
	|
	|-RVA: 0x35D6B0 Offset: 0x35D7B1 VA: 0x35D6B0
	|-Span<double>..ctor
	|
	|-RVA: 0x35DB60 Offset: 0x35DC61 VA: 0x35DB60
	|-Span<int>..ctor
	|
	|-RVA: 0x35E010 Offset: 0x35E111 VA: 0x35E010
	|-Span<long>..ctor
	|
	|-RVA: 0x35E4C0 Offset: 0x35E5C1 VA: 0x35E4C0
	|-Span<object>..ctor
	|
	|-RVA: 0x35E9C0 Offset: 0x35EAC1 VA: 0x35E9C0
	|-Span<float>..ctor
	|
	|-RVA: 0x35EE70 Offset: 0x35EF71 VA: 0x35EE70
	|-Span<ushort>..ctor
	|
	|-RVA: 0x35F320 Offset: 0x35F421 VA: 0x35F320
	|-Span<uint>..ctor
	|
	|-RVA: 0x35F7D0 Offset: 0x35F8D1 VA: 0x35F7D0
	|-Span<Bounds>..ctor
	|
	|-RVA: 0x35FC80 Offset: 0x35FD81 VA: 0x35FC80
	|-Span<Color>..ctor
	|
	|-RVA: 0x360130 Offset: 0x360231 VA: 0x360130
	|-Span<Quaternion>..ctor
	|
	|-RVA: 0x3605E0 Offset: 0x3606E1 VA: 0x3605E0
	|-Span<Rect>..ctor
	|
	|-RVA: 0x360A90 Offset: 0x360B91 VA: 0x360A90
	|-Span<Vector2>..ctor
	|
	|-RVA: 0x360F40 Offset: 0x361041 VA: 0x360F40
	|-Span<Vector3>..ctor
	|
	|-RVA: 0x382F80 Offset: 0x383081 VA: 0x382F80
	|-Span<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CD40 Offset: 0x35CE41 VA: 0x35CD40
	|-Span<byte>.get_Item
	|
	|-RVA: 0x35D240 Offset: 0x35D341 VA: 0x35D240
	|-Span<char>.get_Item
	|
	|-RVA: 0x35D6F0 Offset: 0x35D7F1 VA: 0x35D6F0
	|-Span<double>.get_Item
	|
	|-RVA: 0x35DBA0 Offset: 0x35DCA1 VA: 0x35DBA0
	|-Span<int>.get_Item
	|
	|-RVA: 0x35E050 Offset: 0x35E151 VA: 0x35E050
	|-Span<long>.get_Item
	|
	|-RVA: 0x35E500 Offset: 0x35E601 VA: 0x35E500
	|-Span<object>.get_Item
	|
	|-RVA: 0x35EA00 Offset: 0x35EB01 VA: 0x35EA00
	|-Span<float>.get_Item
	|
	|-RVA: 0x35EEB0 Offset: 0x35EFB1 VA: 0x35EEB0
	|-Span<ushort>.get_Item
	|
	|-RVA: 0x35F360 Offset: 0x35F461 VA: 0x35F360
	|-Span<uint>.get_Item
	|
	|-RVA: 0x35F810 Offset: 0x35F911 VA: 0x35F810
	|-Span<Bounds>.get_Item
	|
	|-RVA: 0x35FCC0 Offset: 0x35FDC1 VA: 0x35FCC0
	|-Span<Color>.get_Item
	|
	|-RVA: 0x360170 Offset: 0x360271 VA: 0x360170
	|-Span<Quaternion>.get_Item
	|
	|-RVA: 0x360620 Offset: 0x360721 VA: 0x360620
	|-Span<Rect>.get_Item
	|
	|-RVA: 0x360AD0 Offset: 0x360BD1 VA: 0x360AD0
	|-Span<Vector2>.get_Item
	|
	|-RVA: 0x360F80 Offset: 0x361081 VA: 0x360F80
	|-Span<Vector3>.get_Item
	|
	|-RVA: 0x382FC0 Offset: 0x3830C1 VA: 0x382FC0
	|-Span<Vector4>.get_Item
	*/

	[EditorBrowsableAttribute] // RVA: 0x128F80 Offset: 0x129081 VA: 0x128F80
	// RVA: -1 Offset: -1
	public ref T GetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CD50 Offset: 0x35CE51 VA: 0x35CD50
	|-Span<byte>.GetPinnableReference
	|
	|-RVA: 0x35D250 Offset: 0x35D351 VA: 0x35D250
	|-Span<char>.GetPinnableReference
	|
	|-RVA: 0x35D700 Offset: 0x35D801 VA: 0x35D700
	|-Span<double>.GetPinnableReference
	|
	|-RVA: 0x35DBB0 Offset: 0x35DCB1 VA: 0x35DBB0
	|-Span<int>.GetPinnableReference
	|
	|-RVA: 0x35E060 Offset: 0x35E161 VA: 0x35E060
	|-Span<long>.GetPinnableReference
	|
	|-RVA: 0x35E510 Offset: 0x35E611 VA: 0x35E510
	|-Span<object>.GetPinnableReference
	|
	|-RVA: 0x35EA10 Offset: 0x35EB11 VA: 0x35EA10
	|-Span<float>.GetPinnableReference
	|
	|-RVA: 0x35EEC0 Offset: 0x35EFC1 VA: 0x35EEC0
	|-Span<ushort>.GetPinnableReference
	|
	|-RVA: 0x35F370 Offset: 0x35F471 VA: 0x35F370
	|-Span<uint>.GetPinnableReference
	|
	|-RVA: 0x35F820 Offset: 0x35F921 VA: 0x35F820
	|-Span<Bounds>.GetPinnableReference
	|
	|-RVA: 0x35FCD0 Offset: 0x35FDD1 VA: 0x35FCD0
	|-Span<Color>.GetPinnableReference
	|
	|-RVA: 0x360180 Offset: 0x360281 VA: 0x360180
	|-Span<Quaternion>.GetPinnableReference
	|
	|-RVA: 0x360630 Offset: 0x360731 VA: 0x360630
	|-Span<Rect>.GetPinnableReference
	|
	|-RVA: 0x360AE0 Offset: 0x360BE1 VA: 0x360AE0
	|-Span<Vector2>.GetPinnableReference
	|
	|-RVA: 0x360F90 Offset: 0x361091 VA: 0x360F90
	|-Span<Vector3>.GetPinnableReference
	|
	|-RVA: 0x382FD0 Offset: 0x3830D1 VA: 0x382FD0
	|-Span<Vector4>.GetPinnableReference
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CD60 Offset: 0x35CE61 VA: 0x35CD60
	|-Span<byte>.Clear
	|
	|-RVA: 0x35D260 Offset: 0x35D361 VA: 0x35D260
	|-Span<char>.Clear
	|
	|-RVA: 0x35D710 Offset: 0x35D811 VA: 0x35D710
	|-Span<double>.Clear
	|
	|-RVA: 0x35DBC0 Offset: 0x35DCC1 VA: 0x35DBC0
	|-Span<int>.Clear
	|
	|-RVA: 0x35E070 Offset: 0x35E171 VA: 0x35E070
	|-Span<long>.Clear
	|
	|-RVA: 0x35E520 Offset: 0x35E621 VA: 0x35E520
	|-Span<object>.Clear
	|
	|-RVA: 0x35EA20 Offset: 0x35EB21 VA: 0x35EA20
	|-Span<float>.Clear
	|
	|-RVA: 0x35EED0 Offset: 0x35EFD1 VA: 0x35EED0
	|-Span<ushort>.Clear
	|
	|-RVA: 0x35F380 Offset: 0x35F481 VA: 0x35F380
	|-Span<uint>.Clear
	|
	|-RVA: 0x35F830 Offset: 0x35F931 VA: 0x35F830
	|-Span<Bounds>.Clear
	|
	|-RVA: 0x35FCE0 Offset: 0x35FDE1 VA: 0x35FCE0
	|-Span<Color>.Clear
	|
	|-RVA: 0x360190 Offset: 0x360291 VA: 0x360190
	|-Span<Quaternion>.Clear
	|
	|-RVA: 0x360640 Offset: 0x360741 VA: 0x360640
	|-Span<Rect>.Clear
	|
	|-RVA: 0x360AF0 Offset: 0x360BF1 VA: 0x360AF0
	|-Span<Vector2>.Clear
	|
	|-RVA: 0x360FA0 Offset: 0x3610A1 VA: 0x360FA0
	|-Span<Vector3>.Clear
	|
	|-RVA: 0x382FE0 Offset: 0x3830E1 VA: 0x382FE0
	|-Span<Vector4>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CD70 Offset: 0x35CE71 VA: 0x35CD70
	|-Span<byte>.CopyTo
	|
	|-RVA: 0x35D270 Offset: 0x35D371 VA: 0x35D270
	|-Span<char>.CopyTo
	|
	|-RVA: 0x35D720 Offset: 0x35D821 VA: 0x35D720
	|-Span<double>.CopyTo
	|
	|-RVA: 0x35DBD0 Offset: 0x35DCD1 VA: 0x35DBD0
	|-Span<int>.CopyTo
	|
	|-RVA: 0x35E080 Offset: 0x35E181 VA: 0x35E080
	|-Span<long>.CopyTo
	|
	|-RVA: 0x35E530 Offset: 0x35E631 VA: 0x35E530
	|-Span<object>.CopyTo
	|
	|-RVA: 0x35EA30 Offset: 0x35EB31 VA: 0x35EA30
	|-Span<float>.CopyTo
	|
	|-RVA: 0x35EEE0 Offset: 0x35EFE1 VA: 0x35EEE0
	|-Span<ushort>.CopyTo
	|
	|-RVA: 0x35F390 Offset: 0x35F491 VA: 0x35F390
	|-Span<uint>.CopyTo
	|
	|-RVA: 0x35F840 Offset: 0x35F941 VA: 0x35F840
	|-Span<Bounds>.CopyTo
	|
	|-RVA: 0x35FCF0 Offset: 0x35FDF1 VA: 0x35FCF0
	|-Span<Color>.CopyTo
	|
	|-RVA: 0x3601A0 Offset: 0x3602A1 VA: 0x3601A0
	|-Span<Quaternion>.CopyTo
	|
	|-RVA: 0x360650 Offset: 0x360751 VA: 0x360650
	|-Span<Rect>.CopyTo
	|
	|-RVA: 0x360B00 Offset: 0x360C01 VA: 0x360B00
	|-Span<Vector2>.CopyTo
	|
	|-RVA: 0x360FB0 Offset: 0x3610B1 VA: 0x360FB0
	|-Span<Vector3>.CopyTo
	|
	|-RVA: 0x382FF0 Offset: 0x3830F1 VA: 0x382FF0
	|-Span<Vector4>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CDF0 Offset: 0x35CEF1 VA: 0x35CDF0
	|-Span<byte>.TryCopyTo
	|
	|-RVA: 0x35D2F0 Offset: 0x35D3F1 VA: 0x35D2F0
	|-Span<char>.TryCopyTo
	|
	|-RVA: 0x35D7A0 Offset: 0x35D8A1 VA: 0x35D7A0
	|-Span<double>.TryCopyTo
	|
	|-RVA: 0x35DC50 Offset: 0x35DD51 VA: 0x35DC50
	|-Span<int>.TryCopyTo
	|
	|-RVA: 0x35E100 Offset: 0x35E201 VA: 0x35E100
	|-Span<long>.TryCopyTo
	|
	|-RVA: 0x35E5B0 Offset: 0x35E6B1 VA: 0x35E5B0
	|-Span<object>.TryCopyTo
	|
	|-RVA: 0x35EAB0 Offset: 0x35EBB1 VA: 0x35EAB0
	|-Span<float>.TryCopyTo
	|
	|-RVA: 0x35EF60 Offset: 0x35F061 VA: 0x35EF60
	|-Span<ushort>.TryCopyTo
	|
	|-RVA: 0x35F410 Offset: 0x35F511 VA: 0x35F410
	|-Span<uint>.TryCopyTo
	|
	|-RVA: 0x35F8C0 Offset: 0x35F9C1 VA: 0x35F8C0
	|-Span<Bounds>.TryCopyTo
	|
	|-RVA: 0x35FD70 Offset: 0x35FE71 VA: 0x35FD70
	|-Span<Color>.TryCopyTo
	|
	|-RVA: 0x360220 Offset: 0x360321 VA: 0x360220
	|-Span<Quaternion>.TryCopyTo
	|
	|-RVA: 0x3606D0 Offset: 0x3607D1 VA: 0x3606D0
	|-Span<Rect>.TryCopyTo
	|
	|-RVA: 0x360B80 Offset: 0x360C81 VA: 0x360B80
	|-Span<Vector2>.TryCopyTo
	|
	|-RVA: 0x361030 Offset: 0x361131 VA: 0x361030
	|-Span<Vector3>.TryCopyTo
	|
	|-RVA: 0x383070 Offset: 0x383171 VA: 0x383070
	|-Span<Vector4>.TryCopyTo
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> op_Implicit(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2683170 Offset: 0x2683271 VA: 0x2683170
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x2684E50 Offset: 0x2684F51 VA: 0x2684E50
	|-Span<char>.op_Implicit
	|
	|-RVA: 0x26866A0 Offset: 0x26867A1 VA: 0x26866A0
	|-Span<double>.op_Implicit
	|
	|-RVA: 0x2687EF0 Offset: 0x2687FF1 VA: 0x2687EF0
	|-Span<int>.op_Implicit
	|
	|-RVA: 0x2689740 Offset: 0x2689841 VA: 0x2689740
	|-Span<long>.op_Implicit
	|
	|-RVA: 0x268B080 Offset: 0x268B181 VA: 0x268B080
	|-Span<object>.op_Implicit
	|
	|-RVA: 0x268CE20 Offset: 0x268CF21 VA: 0x268CE20
	|-Span<float>.op_Implicit
	|
	|-RVA: 0x268E670 Offset: 0x268E771 VA: 0x268E670
	|-Span<ushort>.op_Implicit
	|
	|-RVA: 0x268FEC0 Offset: 0x268FFC1 VA: 0x268FEC0
	|-Span<uint>.op_Implicit
	|
	|-RVA: 0x2691710 Offset: 0x2691811 VA: 0x2691710
	|-Span<Bounds>.op_Implicit
	|
	|-RVA: 0x2692F60 Offset: 0x2693061 VA: 0x2692F60
	|-Span<Color>.op_Implicit
	|
	|-RVA: 0x26947B0 Offset: 0x26948B1 VA: 0x26947B0
	|-Span<Quaternion>.op_Implicit
	|
	|-RVA: 0x2696000 Offset: 0x2696101 VA: 0x2696000
	|-Span<Rect>.op_Implicit
	|
	|-RVA: 0x2697850 Offset: 0x2697951 VA: 0x2697850
	|-Span<Vector2>.op_Implicit
	|
	|-RVA: 0x26990A0 Offset: 0x26991A1 VA: 0x26990A0
	|-Span<Vector3>.op_Implicit
	|
	|-RVA: 0x2B82DF0 Offset: 0x2B82EF1 VA: 0x2B82DF0
	|-Span<Vector4>.op_Implicit
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CE30 Offset: 0x35CF31 VA: 0x35CE30
	|-Span<byte>.ToString
	|
	|-RVA: 0x35D330 Offset: 0x35D431 VA: 0x35D330
	|-Span<char>.ToString
	|
	|-RVA: 0x35D7E0 Offset: 0x35D8E1 VA: 0x35D7E0
	|-Span<double>.ToString
	|
	|-RVA: 0x35DC90 Offset: 0x35DD91 VA: 0x35DC90
	|-Span<int>.ToString
	|
	|-RVA: 0x35E140 Offset: 0x35E241 VA: 0x35E140
	|-Span<long>.ToString
	|
	|-RVA: 0x35E5F0 Offset: 0x35E6F1 VA: 0x35E5F0
	|-Span<object>.ToString
	|
	|-RVA: 0x35EAF0 Offset: 0x35EBF1 VA: 0x35EAF0
	|-Span<float>.ToString
	|
	|-RVA: 0x35EFA0 Offset: 0x35F0A1 VA: 0x35EFA0
	|-Span<ushort>.ToString
	|
	|-RVA: 0x35F450 Offset: 0x35F551 VA: 0x35F450
	|-Span<uint>.ToString
	|
	|-RVA: 0x35F900 Offset: 0x35FA01 VA: 0x35F900
	|-Span<Bounds>.ToString
	|
	|-RVA: 0x35FDB0 Offset: 0x35FEB1 VA: 0x35FDB0
	|-Span<Color>.ToString
	|
	|-RVA: 0x360260 Offset: 0x360361 VA: 0x360260
	|-Span<Quaternion>.ToString
	|
	|-RVA: 0x360710 Offset: 0x360811 VA: 0x360710
	|-Span<Rect>.ToString
	|
	|-RVA: 0x360BC0 Offset: 0x360CC1 VA: 0x360BC0
	|-Span<Vector2>.ToString
	|
	|-RVA: 0x361070 Offset: 0x361171 VA: 0x361070
	|-Span<Vector3>.ToString
	|
	|-RVA: 0x3830B0 Offset: 0x3831B1 VA: 0x3830B0
	|-Span<Vector4>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CE40 Offset: 0x35CF41 VA: 0x35CE40
	|-Span<byte>.Slice
	|
	|-RVA: 0x35D340 Offset: 0x35D441 VA: 0x35D340
	|-Span<char>.Slice
	|
	|-RVA: 0x35D7F0 Offset: 0x35D8F1 VA: 0x35D7F0
	|-Span<double>.Slice
	|
	|-RVA: 0x35DCA0 Offset: 0x35DDA1 VA: 0x35DCA0
	|-Span<int>.Slice
	|
	|-RVA: 0x35E150 Offset: 0x35E251 VA: 0x35E150
	|-Span<long>.Slice
	|
	|-RVA: 0x35E600 Offset: 0x35E701 VA: 0x35E600
	|-Span<object>.Slice
	|
	|-RVA: 0x35EB00 Offset: 0x35EC01 VA: 0x35EB00
	|-Span<float>.Slice
	|
	|-RVA: 0x35EFB0 Offset: 0x35F0B1 VA: 0x35EFB0
	|-Span<ushort>.Slice
	|
	|-RVA: 0x35F460 Offset: 0x35F561 VA: 0x35F460
	|-Span<uint>.Slice
	|
	|-RVA: 0x35F910 Offset: 0x35FA11 VA: 0x35F910
	|-Span<Bounds>.Slice
	|
	|-RVA: 0x35FDC0 Offset: 0x35FEC1 VA: 0x35FDC0
	|-Span<Color>.Slice
	|
	|-RVA: 0x360270 Offset: 0x360371 VA: 0x360270
	|-Span<Quaternion>.Slice
	|
	|-RVA: 0x360720 Offset: 0x360821 VA: 0x360720
	|-Span<Rect>.Slice
	|
	|-RVA: 0x360BD0 Offset: 0x360CD1 VA: 0x360BD0
	|-Span<Vector2>.Slice
	|
	|-RVA: 0x361080 Offset: 0x361181 VA: 0x361080
	|-Span<Vector3>.Slice
	|
	|-RVA: 0x3830C0 Offset: 0x3831C1 VA: 0x3830C0
	|-Span<Vector4>.Slice
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35CF40 Offset: 0x35D041 VA: 0x35CF40
	|-Span<byte>.Slice
	|
	|-RVA: 0x35D440 Offset: 0x35D541 VA: 0x35D440
	|-Span<char>.Slice
	|
	|-RVA: 0x35D8F0 Offset: 0x35D9F1 VA: 0x35D8F0
	|-Span<double>.Slice
	|
	|-RVA: 0x35DDA0 Offset: 0x35DEA1 VA: 0x35DDA0
	|-Span<int>.Slice
	|
	|-RVA: 0x35E250 Offset: 0x35E351 VA: 0x35E250
	|-Span<long>.Slice
	|
	|-RVA: 0x35E700 Offset: 0x35E801 VA: 0x35E700
	|-Span<object>.Slice
	|
	|-RVA: 0x35EC00 Offset: 0x35ED01 VA: 0x35EC00
	|-Span<float>.Slice
	|
	|-RVA: 0x35F0B0 Offset: 0x35F1B1 VA: 0x35F0B0
	|-Span<ushort>.Slice
	|
	|-RVA: 0x35F560 Offset: 0x35F661 VA: 0x35F560
	|-Span<uint>.Slice
	|
	|-RVA: 0x35FA10 Offset: 0x35FB11 VA: 0x35FA10
	|-Span<Bounds>.Slice
	|
	|-RVA: 0x35FEC0 Offset: 0x35FFC1 VA: 0x35FEC0
	|-Span<Color>.Slice
	|
	|-RVA: 0x360370 Offset: 0x360471 VA: 0x360370
	|-Span<Quaternion>.Slice
	|
	|-RVA: 0x360820 Offset: 0x360921 VA: 0x360820
	|-Span<Rect>.Slice
	|
	|-RVA: 0x360CD0 Offset: 0x360DD1 VA: 0x360CD0
	|-Span<Vector2>.Slice
	|
	|-RVA: 0x361180 Offset: 0x361281 VA: 0x361180
	|-Span<Vector3>.Slice
	|
	|-RVA: 0x3831C0 Offset: 0x3832C1 VA: 0x3831C0
	|-Span<Vector4>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x128FA0 Offset: 0x1290A1 VA: 0x128FA0
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35D040 Offset: 0x35D141 VA: 0x35D040
	|-Span<byte>.DangerousGetPinnableReference
	|
	|-RVA: 0x35D540 Offset: 0x35D641 VA: 0x35D540
	|-Span<char>.DangerousGetPinnableReference
	|
	|-RVA: 0x35D9F0 Offset: 0x35DAF1 VA: 0x35D9F0
	|-Span<double>.DangerousGetPinnableReference
	|
	|-RVA: 0x35DEA0 Offset: 0x35DFA1 VA: 0x35DEA0
	|-Span<int>.DangerousGetPinnableReference
	|
	|-RVA: 0x35E350 Offset: 0x35E451 VA: 0x35E350
	|-Span<long>.DangerousGetPinnableReference
	|
	|-RVA: 0x35E800 Offset: 0x35E901 VA: 0x35E800
	|-Span<object>.DangerousGetPinnableReference
	|
	|-RVA: 0x35ED00 Offset: 0x35EE01 VA: 0x35ED00
	|-Span<float>.DangerousGetPinnableReference
	|
	|-RVA: 0x35F1B0 Offset: 0x35F2B1 VA: 0x35F1B0
	|-Span<ushort>.DangerousGetPinnableReference
	|
	|-RVA: 0x35F660 Offset: 0x35F761 VA: 0x35F660
	|-Span<uint>.DangerousGetPinnableReference
	|
	|-RVA: 0x35FB10 Offset: 0x35FC11 VA: 0x35FB10
	|-Span<Bounds>.DangerousGetPinnableReference
	|
	|-RVA: 0x35FFC0 Offset: 0x3600C1 VA: 0x35FFC0
	|-Span<Color>.DangerousGetPinnableReference
	|
	|-RVA: 0x360470 Offset: 0x360571 VA: 0x360470
	|-Span<Quaternion>.DangerousGetPinnableReference
	|
	|-RVA: 0x360920 Offset: 0x360A21 VA: 0x360920
	|-Span<Rect>.DangerousGetPinnableReference
	|
	|-RVA: 0x360DD0 Offset: 0x360ED1 VA: 0x360DD0
	|-Span<Vector2>.DangerousGetPinnableReference
	|
	|-RVA: 0x361280 Offset: 0x361381 VA: 0x361280
	|-Span<Vector3>.DangerousGetPinnableReference
	|
	|-RVA: 0x3832C0 Offset: 0x3833C1 VA: 0x3832C0
	|-Span<Vector4>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35D130 Offset: 0x35D231 VA: 0x35D130
	|-Span<byte>.get_Pinnable
	|
	|-RVA: 0x35D630 Offset: 0x35D731 VA: 0x35D630
	|-Span<char>.get_Pinnable
	|
	|-RVA: 0x35DAE0 Offset: 0x35DBE1 VA: 0x35DAE0
	|-Span<double>.get_Pinnable
	|
	|-RVA: 0x35DF90 Offset: 0x35E091 VA: 0x35DF90
	|-Span<int>.get_Pinnable
	|
	|-RVA: 0x35E440 Offset: 0x35E541 VA: 0x35E440
	|-Span<long>.get_Pinnable
	|
	|-RVA: 0x35E8F0 Offset: 0x35E9F1 VA: 0x35E8F0
	|-Span<object>.get_Pinnable
	|
	|-RVA: 0x35EDF0 Offset: 0x35EEF1 VA: 0x35EDF0
	|-Span<float>.get_Pinnable
	|
	|-RVA: 0x35F2A0 Offset: 0x35F3A1 VA: 0x35F2A0
	|-Span<ushort>.get_Pinnable
	|
	|-RVA: 0x35F750 Offset: 0x35F851 VA: 0x35F750
	|-Span<uint>.get_Pinnable
	|
	|-RVA: 0x35FC00 Offset: 0x35FD01 VA: 0x35FC00
	|-Span<Bounds>.get_Pinnable
	|
	|-RVA: 0x3600B0 Offset: 0x3601B1 VA: 0x3600B0
	|-Span<Color>.get_Pinnable
	|
	|-RVA: 0x360560 Offset: 0x360661 VA: 0x360560
	|-Span<Quaternion>.get_Pinnable
	|
	|-RVA: 0x360A10 Offset: 0x360B11 VA: 0x360A10
	|-Span<Rect>.get_Pinnable
	|
	|-RVA: 0x360EC0 Offset: 0x360FC1 VA: 0x360EC0
	|-Span<Vector2>.get_Pinnable
	|
	|-RVA: 0x361370 Offset: 0x361471 VA: 0x361370
	|-Span<Vector3>.get_Pinnable
	|
	|-RVA: 0x3833B0 Offset: 0x3834B1 VA: 0x3833B0
	|-Span<Vector4>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35D140 Offset: 0x35D241 VA: 0x35D140
	|-Span<byte>.get_ByteOffset
	|
	|-RVA: 0x35D640 Offset: 0x35D741 VA: 0x35D640
	|-Span<char>.get_ByteOffset
	|
	|-RVA: 0x35DAF0 Offset: 0x35DBF1 VA: 0x35DAF0
	|-Span<double>.get_ByteOffset
	|
	|-RVA: 0x35DFA0 Offset: 0x35E0A1 VA: 0x35DFA0
	|-Span<int>.get_ByteOffset
	|
	|-RVA: 0x35E450 Offset: 0x35E551 VA: 0x35E450
	|-Span<long>.get_ByteOffset
	|
	|-RVA: 0x35E900 Offset: 0x35EA01 VA: 0x35E900
	|-Span<object>.get_ByteOffset
	|
	|-RVA: 0x35EE00 Offset: 0x35EF01 VA: 0x35EE00
	|-Span<float>.get_ByteOffset
	|
	|-RVA: 0x35F2B0 Offset: 0x35F3B1 VA: 0x35F2B0
	|-Span<ushort>.get_ByteOffset
	|
	|-RVA: 0x35F760 Offset: 0x35F861 VA: 0x35F760
	|-Span<uint>.get_ByteOffset
	|
	|-RVA: 0x35FC10 Offset: 0x35FD11 VA: 0x35FC10
	|-Span<Bounds>.get_ByteOffset
	|
	|-RVA: 0x3600C0 Offset: 0x3601C1 VA: 0x3600C0
	|-Span<Color>.get_ByteOffset
	|
	|-RVA: 0x360570 Offset: 0x360671 VA: 0x360570
	|-Span<Quaternion>.get_ByteOffset
	|
	|-RVA: 0x360A20 Offset: 0x360B21 VA: 0x360A20
	|-Span<Rect>.get_ByteOffset
	|
	|-RVA: 0x360ED0 Offset: 0x360FD1 VA: 0x360ED0
	|-Span<Vector2>.get_ByteOffset
	|
	|-RVA: 0x361380 Offset: 0x361481 VA: 0x361380
	|-Span<Vector3>.get_ByteOffset
	|
	|-RVA: 0x3833C0 Offset: 0x3834C1 VA: 0x3833C0
	|-Span<Vector4>.get_ByteOffset
	*/
}

