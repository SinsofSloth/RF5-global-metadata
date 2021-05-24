[DebuggerDisplayAttribute] // RVA: 0x13EE60 Offset: 0x13EF61 VA: 0x13EE60
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5876
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA10 Offset: 0x36CB11 VA: 0x36CA10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CE80 Offset: 0x36CF81 VA: 0x36CE80
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|
	|-RVA: 0x36D2F0 Offset: 0x36D3F1 VA: 0x36D2F0
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x36D7B0 Offset: 0x36D8B1 VA: 0x36D7B0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC20 Offset: 0x36DD21 VA: 0x36DC20
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E0E0 Offset: 0x36E1E1 VA: 0x36E0E0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E650 Offset: 0x36E751 VA: 0x36E650
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EB60 Offset: 0x36EC61 VA: 0x36EB60
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA50 Offset: 0x36CB51 VA: 0x36CA50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CEC0 Offset: 0x36CFC1 VA: 0x36CEC0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|
	|-RVA: 0x36D340 Offset: 0x36D441 VA: 0x36D340
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D7F0 Offset: 0x36D8F1 VA: 0x36D7F0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC70 Offset: 0x36DD71 VA: 0x36DC70
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E130 Offset: 0x36E231 VA: 0x36E130
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E6B0 Offset: 0x36E7B1 VA: 0x36E6B0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EBA0 Offset: 0x36ECA1 VA: 0x36EBA0
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAD0 Offset: 0x36CBD1 VA: 0x36CAD0
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CF40 Offset: 0x36D041 VA: 0x36CF40
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x36D3D0 Offset: 0x36D4D1 VA: 0x36D3D0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D870 Offset: 0x36D971 VA: 0x36D870
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DD00 Offset: 0x36DE01 VA: 0x36DD00
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E1C0 Offset: 0x36E2C1 VA: 0x36E1C0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E750 Offset: 0x36E851 VA: 0x36E750
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EC20 Offset: 0x36ED21 VA: 0x36EC20
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB60 Offset: 0x36CC61 VA: 0x36CB60
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x36CFD0 Offset: 0x36D0D1 VA: 0x36CFD0
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x36D460 Offset: 0x36D561 VA: 0x36D460
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x36D900 Offset: 0x36DA01 VA: 0x36D900
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x36DDA0 Offset: 0x36DEA1 VA: 0x36DDA0
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x36E260 Offset: 0x36E361 VA: 0x36E260
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x36E7F0 Offset: 0x36E8F1 VA: 0x36E7F0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x36ECB0 Offset: 0x36EDB1 VA: 0x36ECB0
	|-TMP_TextProcessingStack<Color32>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB70 Offset: 0x36CC71 VA: 0x36CB70
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x36CFE0 Offset: 0x36D0E1 VA: 0x36CFE0
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x36D470 Offset: 0x36D571 VA: 0x36D470
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x36D910 Offset: 0x36DA11 VA: 0x36D910
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x36DDB0 Offset: 0x36DEB1 VA: 0x36DDB0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x36E270 Offset: 0x36E371 VA: 0x36E270
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x36E800 Offset: 0x36E901 VA: 0x36E800
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x36ECC0 Offset: 0x36EDC1 VA: 0x36ECC0
	|-TMP_TextProcessingStack<Color32>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBE0 Offset: 0x36CCE1 VA: 0x36CBE0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x36D050 Offset: 0x36D151 VA: 0x36D050
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x36D4E0 Offset: 0x36D5E1 VA: 0x36D4E0
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x36D980 Offset: 0x36DA81 VA: 0x36D980
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x36DE20 Offset: 0x36DF21 VA: 0x36DE20
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x36E2F0 Offset: 0x36E3F1 VA: 0x36E2F0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x36E870 Offset: 0x36E971 VA: 0x36E870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x36ED30 Offset: 0x36EE31 VA: 0x36ED30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF0 Offset: 0x36CCF1 VA: 0x36CBF0
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x36D060 Offset: 0x36D161 VA: 0x36D060
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x36D4F0 Offset: 0x36D5F1 VA: 0x36D4F0
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x36D990 Offset: 0x36DA91 VA: 0x36D990
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x36DE30 Offset: 0x36DF31 VA: 0x36DE30
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x36E300 Offset: 0x36E401 VA: 0x36E300
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x36E880 Offset: 0x36E981 VA: 0x36E880
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x36ED40 Offset: 0x36EE41 VA: 0x36ED40
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC00 Offset: 0x36CD01 VA: 0x36CC00
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x36D070 Offset: 0x36D171 VA: 0x36D070
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x36D500 Offset: 0x36D601 VA: 0x36D500
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x36D9A0 Offset: 0x36DAA1 VA: 0x36D9A0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x36DE40 Offset: 0x36DF41 VA: 0x36DE40
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x36E310 Offset: 0x36E411 VA: 0x36E310
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x36E890 Offset: 0x36E991 VA: 0x36E890
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x36ED50 Offset: 0x36EE51 VA: 0x36ED50
	|-TMP_TextProcessingStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC10 Offset: 0x36CD11 VA: 0x36CC10
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x36D080 Offset: 0x36D181 VA: 0x36D080
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|
	|-RVA: 0x36D510 Offset: 0x36D611 VA: 0x36D510
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x36D9B0 Offset: 0x36DAB1 VA: 0x36D9B0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x36DE50 Offset: 0x36DF51 VA: 0x36DE50
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x36E320 Offset: 0x36E421 VA: 0x36E320
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x36E8A0 Offset: 0x36E9A1 VA: 0x36E8A0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x36ED60 Offset: 0x36EE61 VA: 0x36ED60
	|-TMP_TextProcessingStack<Color32>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC20 Offset: 0x36CD21 VA: 0x36CC20
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x36D090 Offset: 0x36D191 VA: 0x36D090
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|
	|-RVA: 0x36D520 Offset: 0x36D621 VA: 0x36D520
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x36D9C0 Offset: 0x36DAC1 VA: 0x36D9C0
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x36DE90 Offset: 0x36DF91 VA: 0x36DE90
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x36E370 Offset: 0x36E471 VA: 0x36E370
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x36E8F0 Offset: 0x36E9F1 VA: 0x36E8F0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x36ED70 Offset: 0x36EE71 VA: 0x36ED70
	|-TMP_TextProcessingStack<Color32>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC80 Offset: 0x36CD81 VA: 0x36CC80
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x36D0F0 Offset: 0x36D1F1 VA: 0x36D0F0
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|
	|-RVA: 0x36D590 Offset: 0x36D691 VA: 0x36D590
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x36DA20 Offset: 0x36DB21 VA: 0x36DA20
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x36DF20 Offset: 0x36E021 VA: 0x36DF20
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x36E450 Offset: 0x36E551 VA: 0x36E450
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x36E9A0 Offset: 0x36EAA1 VA: 0x36E9A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x36EDD0 Offset: 0x36EED1 VA: 0x36EDD0
	|-TMP_TextProcessingStack<Color32>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC90 Offset: 0x36CD91 VA: 0x36CC90
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x36D100 Offset: 0x36D201 VA: 0x36D100
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x36D5A0 Offset: 0x36D6A1 VA: 0x36D5A0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x36DA30 Offset: 0x36DB31 VA: 0x36DA30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x36DF30 Offset: 0x36E031 VA: 0x36DF30
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x36E460 Offset: 0x36E561 VA: 0x36E460
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x36E9B0 Offset: 0x36EAB1 VA: 0x36E9B0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x36EDF0 Offset: 0x36EEF1 VA: 0x36EDF0
	|-TMP_TextProcessingStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCA0 Offset: 0x36CDA1 VA: 0x36CCA0
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x36D110 Offset: 0x36D211 VA: 0x36D110
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x36D5B0 Offset: 0x36D6B1 VA: 0x36D5B0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x36DA40 Offset: 0x36DB41 VA: 0x36DA40
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x36DF70 Offset: 0x36E071 VA: 0x36DF70
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x36E4B0 Offset: 0x36E5B1 VA: 0x36E4B0
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x36EA00 Offset: 0x36EB01 VA: 0x36EA00
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x36EE00 Offset: 0x36EF01 VA: 0x36EE00
	|-TMP_TextProcessingStack<Color32>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD40 Offset: 0x36CE41 VA: 0x36CD40
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x36D1B0 Offset: 0x36D2B1 VA: 0x36D1B0
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|
	|-RVA: 0x36D670 Offset: 0x36D771 VA: 0x36D670
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x36DAE0 Offset: 0x36DBE1 VA: 0x36DAE0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x36DF80 Offset: 0x36E081 VA: 0x36DF80
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x36E4C0 Offset: 0x36E5C1 VA: 0x36E4C0
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x36EA10 Offset: 0x36EB11 VA: 0x36EA10
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x36EEA0 Offset: 0x36EFA1 VA: 0x36EEA0
	|-TMP_TextProcessingStack<Color32>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CDA0 Offset: 0x36CEA1 VA: 0x36CDA0
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x36D210 Offset: 0x36D311 VA: 0x36D210
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x36D6D0 Offset: 0x36D7D1 VA: 0x36D6D0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x36DB40 Offset: 0x36DC41 VA: 0x36DB40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x36E000 Offset: 0x36E101 VA: 0x36E000
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x36E550 Offset: 0x36E651 VA: 0x36E550
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x36EA80 Offset: 0x36EB81 VA: 0x36EA80
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x36EF00 Offset: 0x36F001 VA: 0x36EF00
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE10 Offset: 0x36CF11 VA: 0x36CE10
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x36D280 Offset: 0x36D381 VA: 0x36D280
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x36D740 Offset: 0x36D841 VA: 0x36D740
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x36DBB0 Offset: 0x36DCB1 VA: 0x36DBB0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x36E070 Offset: 0x36E171 VA: 0x36E070
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x36E5D0 Offset: 0x36E6D1 VA: 0x36E5D0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x36EAF0 Offset: 0x36EBF1 VA: 0x36EAF0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x36EF70 Offset: 0x36F071 VA: 0x36EF70
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	*/
}

[DebuggerDisplayAttribute] // RVA: 0x13EE60 Offset: 0x13EF61 VA: 0x13EE60
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5876
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA10 Offset: 0x36CB11 VA: 0x36CA10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CE80 Offset: 0x36CF81 VA: 0x36CE80
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|
	|-RVA: 0x36D2F0 Offset: 0x36D3F1 VA: 0x36D2F0
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x36D7B0 Offset: 0x36D8B1 VA: 0x36D7B0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC20 Offset: 0x36DD21 VA: 0x36DC20
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E0E0 Offset: 0x36E1E1 VA: 0x36E0E0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E650 Offset: 0x36E751 VA: 0x36E650
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EB60 Offset: 0x36EC61 VA: 0x36EB60
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA50 Offset: 0x36CB51 VA: 0x36CA50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CEC0 Offset: 0x36CFC1 VA: 0x36CEC0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|
	|-RVA: 0x36D340 Offset: 0x36D441 VA: 0x36D340
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D7F0 Offset: 0x36D8F1 VA: 0x36D7F0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC70 Offset: 0x36DD71 VA: 0x36DC70
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E130 Offset: 0x36E231 VA: 0x36E130
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E6B0 Offset: 0x36E7B1 VA: 0x36E6B0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EBA0 Offset: 0x36ECA1 VA: 0x36EBA0
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAD0 Offset: 0x36CBD1 VA: 0x36CAD0
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CF40 Offset: 0x36D041 VA: 0x36CF40
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x36D3D0 Offset: 0x36D4D1 VA: 0x36D3D0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D870 Offset: 0x36D971 VA: 0x36D870
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DD00 Offset: 0x36DE01 VA: 0x36DD00
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E1C0 Offset: 0x36E2C1 VA: 0x36E1C0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E750 Offset: 0x36E851 VA: 0x36E750
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EC20 Offset: 0x36ED21 VA: 0x36EC20
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB60 Offset: 0x36CC61 VA: 0x36CB60
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x36CFD0 Offset: 0x36D0D1 VA: 0x36CFD0
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x36D460 Offset: 0x36D561 VA: 0x36D460
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x36D900 Offset: 0x36DA01 VA: 0x36D900
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x36DDA0 Offset: 0x36DEA1 VA: 0x36DDA0
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x36E260 Offset: 0x36E361 VA: 0x36E260
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x36E7F0 Offset: 0x36E8F1 VA: 0x36E7F0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x36ECB0 Offset: 0x36EDB1 VA: 0x36ECB0
	|-TMP_TextProcessingStack<Color32>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB70 Offset: 0x36CC71 VA: 0x36CB70
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x36CFE0 Offset: 0x36D0E1 VA: 0x36CFE0
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x36D470 Offset: 0x36D571 VA: 0x36D470
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x36D910 Offset: 0x36DA11 VA: 0x36D910
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x36DDB0 Offset: 0x36DEB1 VA: 0x36DDB0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x36E270 Offset: 0x36E371 VA: 0x36E270
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x36E800 Offset: 0x36E901 VA: 0x36E800
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x36ECC0 Offset: 0x36EDC1 VA: 0x36ECC0
	|-TMP_TextProcessingStack<Color32>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBE0 Offset: 0x36CCE1 VA: 0x36CBE0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x36D050 Offset: 0x36D151 VA: 0x36D050
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x36D4E0 Offset: 0x36D5E1 VA: 0x36D4E0
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x36D980 Offset: 0x36DA81 VA: 0x36D980
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x36DE20 Offset: 0x36DF21 VA: 0x36DE20
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x36E2F0 Offset: 0x36E3F1 VA: 0x36E2F0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x36E870 Offset: 0x36E971 VA: 0x36E870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x36ED30 Offset: 0x36EE31 VA: 0x36ED30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF0 Offset: 0x36CCF1 VA: 0x36CBF0
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x36D060 Offset: 0x36D161 VA: 0x36D060
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x36D4F0 Offset: 0x36D5F1 VA: 0x36D4F0
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x36D990 Offset: 0x36DA91 VA: 0x36D990
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x36DE30 Offset: 0x36DF31 VA: 0x36DE30
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x36E300 Offset: 0x36E401 VA: 0x36E300
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x36E880 Offset: 0x36E981 VA: 0x36E880
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x36ED40 Offset: 0x36EE41 VA: 0x36ED40
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC00 Offset: 0x36CD01 VA: 0x36CC00
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x36D070 Offset: 0x36D171 VA: 0x36D070
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x36D500 Offset: 0x36D601 VA: 0x36D500
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x36D9A0 Offset: 0x36DAA1 VA: 0x36D9A0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x36DE40 Offset: 0x36DF41 VA: 0x36DE40
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x36E310 Offset: 0x36E411 VA: 0x36E310
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x36E890 Offset: 0x36E991 VA: 0x36E890
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x36ED50 Offset: 0x36EE51 VA: 0x36ED50
	|-TMP_TextProcessingStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC10 Offset: 0x36CD11 VA: 0x36CC10
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x36D080 Offset: 0x36D181 VA: 0x36D080
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|
	|-RVA: 0x36D510 Offset: 0x36D611 VA: 0x36D510
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x36D9B0 Offset: 0x36DAB1 VA: 0x36D9B0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x36DE50 Offset: 0x36DF51 VA: 0x36DE50
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x36E320 Offset: 0x36E421 VA: 0x36E320
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x36E8A0 Offset: 0x36E9A1 VA: 0x36E8A0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x36ED60 Offset: 0x36EE61 VA: 0x36ED60
	|-TMP_TextProcessingStack<Color32>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC20 Offset: 0x36CD21 VA: 0x36CC20
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x36D090 Offset: 0x36D191 VA: 0x36D090
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|
	|-RVA: 0x36D520 Offset: 0x36D621 VA: 0x36D520
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x36D9C0 Offset: 0x36DAC1 VA: 0x36D9C0
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x36DE90 Offset: 0x36DF91 VA: 0x36DE90
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x36E370 Offset: 0x36E471 VA: 0x36E370
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x36E8F0 Offset: 0x36E9F1 VA: 0x36E8F0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x36ED70 Offset: 0x36EE71 VA: 0x36ED70
	|-TMP_TextProcessingStack<Color32>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC80 Offset: 0x36CD81 VA: 0x36CC80
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x36D0F0 Offset: 0x36D1F1 VA: 0x36D0F0
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|
	|-RVA: 0x36D590 Offset: 0x36D691 VA: 0x36D590
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x36DA20 Offset: 0x36DB21 VA: 0x36DA20
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x36DF20 Offset: 0x36E021 VA: 0x36DF20
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x36E450 Offset: 0x36E551 VA: 0x36E450
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x36E9A0 Offset: 0x36EAA1 VA: 0x36E9A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x36EDD0 Offset: 0x36EED1 VA: 0x36EDD0
	|-TMP_TextProcessingStack<Color32>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC90 Offset: 0x36CD91 VA: 0x36CC90
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x36D100 Offset: 0x36D201 VA: 0x36D100
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x36D5A0 Offset: 0x36D6A1 VA: 0x36D5A0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x36DA30 Offset: 0x36DB31 VA: 0x36DA30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x36DF30 Offset: 0x36E031 VA: 0x36DF30
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x36E460 Offset: 0x36E561 VA: 0x36E460
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x36E9B0 Offset: 0x36EAB1 VA: 0x36E9B0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x36EDF0 Offset: 0x36EEF1 VA: 0x36EDF0
	|-TMP_TextProcessingStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCA0 Offset: 0x36CDA1 VA: 0x36CCA0
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x36D110 Offset: 0x36D211 VA: 0x36D110
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x36D5B0 Offset: 0x36D6B1 VA: 0x36D5B0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x36DA40 Offset: 0x36DB41 VA: 0x36DA40
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x36DF70 Offset: 0x36E071 VA: 0x36DF70
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x36E4B0 Offset: 0x36E5B1 VA: 0x36E4B0
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x36EA00 Offset: 0x36EB01 VA: 0x36EA00
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x36EE00 Offset: 0x36EF01 VA: 0x36EE00
	|-TMP_TextProcessingStack<Color32>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD40 Offset: 0x36CE41 VA: 0x36CD40
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x36D1B0 Offset: 0x36D2B1 VA: 0x36D1B0
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|
	|-RVA: 0x36D670 Offset: 0x36D771 VA: 0x36D670
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x36DAE0 Offset: 0x36DBE1 VA: 0x36DAE0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x36DF80 Offset: 0x36E081 VA: 0x36DF80
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x36E4C0 Offset: 0x36E5C1 VA: 0x36E4C0
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x36EA10 Offset: 0x36EB11 VA: 0x36EA10
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x36EEA0 Offset: 0x36EFA1 VA: 0x36EEA0
	|-TMP_TextProcessingStack<Color32>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CDA0 Offset: 0x36CEA1 VA: 0x36CDA0
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x36D210 Offset: 0x36D311 VA: 0x36D210
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x36D6D0 Offset: 0x36D7D1 VA: 0x36D6D0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x36DB40 Offset: 0x36DC41 VA: 0x36DB40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x36E000 Offset: 0x36E101 VA: 0x36E000
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x36E550 Offset: 0x36E651 VA: 0x36E550
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x36EA80 Offset: 0x36EB81 VA: 0x36EA80
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x36EF00 Offset: 0x36F001 VA: 0x36EF00
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE10 Offset: 0x36CF11 VA: 0x36CE10
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x36D280 Offset: 0x36D381 VA: 0x36D280
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x36D740 Offset: 0x36D841 VA: 0x36D740
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x36DBB0 Offset: 0x36DCB1 VA: 0x36DBB0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x36E070 Offset: 0x36E171 VA: 0x36E070
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x36E5D0 Offset: 0x36E6D1 VA: 0x36E5D0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x36EAF0 Offset: 0x36EBF1 VA: 0x36EAF0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x36EF70 Offset: 0x36F071 VA: 0x36EF70
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	*/
}

[DebuggerDisplayAttribute] // RVA: 0x13EE60 Offset: 0x13EF61 VA: 0x13EE60
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5876
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA10 Offset: 0x36CB11 VA: 0x36CA10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CE80 Offset: 0x36CF81 VA: 0x36CE80
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|
	|-RVA: 0x36D2F0 Offset: 0x36D3F1 VA: 0x36D2F0
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x36D7B0 Offset: 0x36D8B1 VA: 0x36D7B0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC20 Offset: 0x36DD21 VA: 0x36DC20
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E0E0 Offset: 0x36E1E1 VA: 0x36E0E0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E650 Offset: 0x36E751 VA: 0x36E650
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EB60 Offset: 0x36EC61 VA: 0x36EB60
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA50 Offset: 0x36CB51 VA: 0x36CA50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CEC0 Offset: 0x36CFC1 VA: 0x36CEC0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|
	|-RVA: 0x36D340 Offset: 0x36D441 VA: 0x36D340
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D7F0 Offset: 0x36D8F1 VA: 0x36D7F0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC70 Offset: 0x36DD71 VA: 0x36DC70
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E130 Offset: 0x36E231 VA: 0x36E130
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E6B0 Offset: 0x36E7B1 VA: 0x36E6B0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EBA0 Offset: 0x36ECA1 VA: 0x36EBA0
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAD0 Offset: 0x36CBD1 VA: 0x36CAD0
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CF40 Offset: 0x36D041 VA: 0x36CF40
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x36D3D0 Offset: 0x36D4D1 VA: 0x36D3D0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D870 Offset: 0x36D971 VA: 0x36D870
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DD00 Offset: 0x36DE01 VA: 0x36DD00
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E1C0 Offset: 0x36E2C1 VA: 0x36E1C0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E750 Offset: 0x36E851 VA: 0x36E750
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EC20 Offset: 0x36ED21 VA: 0x36EC20
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB60 Offset: 0x36CC61 VA: 0x36CB60
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x36CFD0 Offset: 0x36D0D1 VA: 0x36CFD0
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x36D460 Offset: 0x36D561 VA: 0x36D460
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x36D900 Offset: 0x36DA01 VA: 0x36D900
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x36DDA0 Offset: 0x36DEA1 VA: 0x36DDA0
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x36E260 Offset: 0x36E361 VA: 0x36E260
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x36E7F0 Offset: 0x36E8F1 VA: 0x36E7F0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x36ECB0 Offset: 0x36EDB1 VA: 0x36ECB0
	|-TMP_TextProcessingStack<Color32>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB70 Offset: 0x36CC71 VA: 0x36CB70
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x36CFE0 Offset: 0x36D0E1 VA: 0x36CFE0
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x36D470 Offset: 0x36D571 VA: 0x36D470
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x36D910 Offset: 0x36DA11 VA: 0x36D910
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x36DDB0 Offset: 0x36DEB1 VA: 0x36DDB0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x36E270 Offset: 0x36E371 VA: 0x36E270
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x36E800 Offset: 0x36E901 VA: 0x36E800
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x36ECC0 Offset: 0x36EDC1 VA: 0x36ECC0
	|-TMP_TextProcessingStack<Color32>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBE0 Offset: 0x36CCE1 VA: 0x36CBE0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x36D050 Offset: 0x36D151 VA: 0x36D050
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x36D4E0 Offset: 0x36D5E1 VA: 0x36D4E0
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x36D980 Offset: 0x36DA81 VA: 0x36D980
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x36DE20 Offset: 0x36DF21 VA: 0x36DE20
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x36E2F0 Offset: 0x36E3F1 VA: 0x36E2F0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x36E870 Offset: 0x36E971 VA: 0x36E870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x36ED30 Offset: 0x36EE31 VA: 0x36ED30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF0 Offset: 0x36CCF1 VA: 0x36CBF0
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x36D060 Offset: 0x36D161 VA: 0x36D060
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x36D4F0 Offset: 0x36D5F1 VA: 0x36D4F0
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x36D990 Offset: 0x36DA91 VA: 0x36D990
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x36DE30 Offset: 0x36DF31 VA: 0x36DE30
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x36E300 Offset: 0x36E401 VA: 0x36E300
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x36E880 Offset: 0x36E981 VA: 0x36E880
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x36ED40 Offset: 0x36EE41 VA: 0x36ED40
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC00 Offset: 0x36CD01 VA: 0x36CC00
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x36D070 Offset: 0x36D171 VA: 0x36D070
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x36D500 Offset: 0x36D601 VA: 0x36D500
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x36D9A0 Offset: 0x36DAA1 VA: 0x36D9A0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x36DE40 Offset: 0x36DF41 VA: 0x36DE40
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x36E310 Offset: 0x36E411 VA: 0x36E310
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x36E890 Offset: 0x36E991 VA: 0x36E890
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x36ED50 Offset: 0x36EE51 VA: 0x36ED50
	|-TMP_TextProcessingStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC10 Offset: 0x36CD11 VA: 0x36CC10
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x36D080 Offset: 0x36D181 VA: 0x36D080
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|
	|-RVA: 0x36D510 Offset: 0x36D611 VA: 0x36D510
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x36D9B0 Offset: 0x36DAB1 VA: 0x36D9B0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x36DE50 Offset: 0x36DF51 VA: 0x36DE50
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x36E320 Offset: 0x36E421 VA: 0x36E320
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x36E8A0 Offset: 0x36E9A1 VA: 0x36E8A0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x36ED60 Offset: 0x36EE61 VA: 0x36ED60
	|-TMP_TextProcessingStack<Color32>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC20 Offset: 0x36CD21 VA: 0x36CC20
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x36D090 Offset: 0x36D191 VA: 0x36D090
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|
	|-RVA: 0x36D520 Offset: 0x36D621 VA: 0x36D520
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x36D9C0 Offset: 0x36DAC1 VA: 0x36D9C0
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x36DE90 Offset: 0x36DF91 VA: 0x36DE90
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x36E370 Offset: 0x36E471 VA: 0x36E370
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x36E8F0 Offset: 0x36E9F1 VA: 0x36E8F0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x36ED70 Offset: 0x36EE71 VA: 0x36ED70
	|-TMP_TextProcessingStack<Color32>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC80 Offset: 0x36CD81 VA: 0x36CC80
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x36D0F0 Offset: 0x36D1F1 VA: 0x36D0F0
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|
	|-RVA: 0x36D590 Offset: 0x36D691 VA: 0x36D590
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x36DA20 Offset: 0x36DB21 VA: 0x36DA20
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x36DF20 Offset: 0x36E021 VA: 0x36DF20
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x36E450 Offset: 0x36E551 VA: 0x36E450
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x36E9A0 Offset: 0x36EAA1 VA: 0x36E9A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x36EDD0 Offset: 0x36EED1 VA: 0x36EDD0
	|-TMP_TextProcessingStack<Color32>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC90 Offset: 0x36CD91 VA: 0x36CC90
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x36D100 Offset: 0x36D201 VA: 0x36D100
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x36D5A0 Offset: 0x36D6A1 VA: 0x36D5A0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x36DA30 Offset: 0x36DB31 VA: 0x36DA30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x36DF30 Offset: 0x36E031 VA: 0x36DF30
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x36E460 Offset: 0x36E561 VA: 0x36E460
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x36E9B0 Offset: 0x36EAB1 VA: 0x36E9B0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x36EDF0 Offset: 0x36EEF1 VA: 0x36EDF0
	|-TMP_TextProcessingStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCA0 Offset: 0x36CDA1 VA: 0x36CCA0
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x36D110 Offset: 0x36D211 VA: 0x36D110
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x36D5B0 Offset: 0x36D6B1 VA: 0x36D5B0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x36DA40 Offset: 0x36DB41 VA: 0x36DA40
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x36DF70 Offset: 0x36E071 VA: 0x36DF70
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x36E4B0 Offset: 0x36E5B1 VA: 0x36E4B0
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x36EA00 Offset: 0x36EB01 VA: 0x36EA00
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x36EE00 Offset: 0x36EF01 VA: 0x36EE00
	|-TMP_TextProcessingStack<Color32>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD40 Offset: 0x36CE41 VA: 0x36CD40
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x36D1B0 Offset: 0x36D2B1 VA: 0x36D1B0
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|
	|-RVA: 0x36D670 Offset: 0x36D771 VA: 0x36D670
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x36DAE0 Offset: 0x36DBE1 VA: 0x36DAE0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x36DF80 Offset: 0x36E081 VA: 0x36DF80
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x36E4C0 Offset: 0x36E5C1 VA: 0x36E4C0
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x36EA10 Offset: 0x36EB11 VA: 0x36EA10
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x36EEA0 Offset: 0x36EFA1 VA: 0x36EEA0
	|-TMP_TextProcessingStack<Color32>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CDA0 Offset: 0x36CEA1 VA: 0x36CDA0
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x36D210 Offset: 0x36D311 VA: 0x36D210
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x36D6D0 Offset: 0x36D7D1 VA: 0x36D6D0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x36DB40 Offset: 0x36DC41 VA: 0x36DB40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x36E000 Offset: 0x36E101 VA: 0x36E000
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x36E550 Offset: 0x36E651 VA: 0x36E550
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x36EA80 Offset: 0x36EB81 VA: 0x36EA80
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x36EF00 Offset: 0x36F001 VA: 0x36EF00
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE10 Offset: 0x36CF11 VA: 0x36CE10
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x36D280 Offset: 0x36D381 VA: 0x36D280
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x36D740 Offset: 0x36D841 VA: 0x36D740
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x36DBB0 Offset: 0x36DCB1 VA: 0x36DBB0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x36E070 Offset: 0x36E171 VA: 0x36E070
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x36E5D0 Offset: 0x36E6D1 VA: 0x36E5D0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x36EAF0 Offset: 0x36EBF1 VA: 0x36EAF0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x36EF70 Offset: 0x36F071 VA: 0x36EF70
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	*/
}

[DebuggerDisplayAttribute] // RVA: 0x13EE60 Offset: 0x13EF61 VA: 0x13EE60
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5876
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA10 Offset: 0x36CB11 VA: 0x36CA10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CE80 Offset: 0x36CF81 VA: 0x36CE80
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|
	|-RVA: 0x36D2F0 Offset: 0x36D3F1 VA: 0x36D2F0
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x36D7B0 Offset: 0x36D8B1 VA: 0x36D7B0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC20 Offset: 0x36DD21 VA: 0x36DC20
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E0E0 Offset: 0x36E1E1 VA: 0x36E0E0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E650 Offset: 0x36E751 VA: 0x36E650
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EB60 Offset: 0x36EC61 VA: 0x36EB60
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA50 Offset: 0x36CB51 VA: 0x36CA50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CEC0 Offset: 0x36CFC1 VA: 0x36CEC0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|
	|-RVA: 0x36D340 Offset: 0x36D441 VA: 0x36D340
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D7F0 Offset: 0x36D8F1 VA: 0x36D7F0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC70 Offset: 0x36DD71 VA: 0x36DC70
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E130 Offset: 0x36E231 VA: 0x36E130
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E6B0 Offset: 0x36E7B1 VA: 0x36E6B0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EBA0 Offset: 0x36ECA1 VA: 0x36EBA0
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAD0 Offset: 0x36CBD1 VA: 0x36CAD0
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CF40 Offset: 0x36D041 VA: 0x36CF40
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x36D3D0 Offset: 0x36D4D1 VA: 0x36D3D0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D870 Offset: 0x36D971 VA: 0x36D870
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DD00 Offset: 0x36DE01 VA: 0x36DD00
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E1C0 Offset: 0x36E2C1 VA: 0x36E1C0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E750 Offset: 0x36E851 VA: 0x36E750
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EC20 Offset: 0x36ED21 VA: 0x36EC20
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB60 Offset: 0x36CC61 VA: 0x36CB60
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x36CFD0 Offset: 0x36D0D1 VA: 0x36CFD0
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x36D460 Offset: 0x36D561 VA: 0x36D460
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x36D900 Offset: 0x36DA01 VA: 0x36D900
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x36DDA0 Offset: 0x36DEA1 VA: 0x36DDA0
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x36E260 Offset: 0x36E361 VA: 0x36E260
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x36E7F0 Offset: 0x36E8F1 VA: 0x36E7F0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x36ECB0 Offset: 0x36EDB1 VA: 0x36ECB0
	|-TMP_TextProcessingStack<Color32>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB70 Offset: 0x36CC71 VA: 0x36CB70
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x36CFE0 Offset: 0x36D0E1 VA: 0x36CFE0
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x36D470 Offset: 0x36D571 VA: 0x36D470
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x36D910 Offset: 0x36DA11 VA: 0x36D910
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x36DDB0 Offset: 0x36DEB1 VA: 0x36DDB0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x36E270 Offset: 0x36E371 VA: 0x36E270
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x36E800 Offset: 0x36E901 VA: 0x36E800
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x36ECC0 Offset: 0x36EDC1 VA: 0x36ECC0
	|-TMP_TextProcessingStack<Color32>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBE0 Offset: 0x36CCE1 VA: 0x36CBE0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x36D050 Offset: 0x36D151 VA: 0x36D050
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x36D4E0 Offset: 0x36D5E1 VA: 0x36D4E0
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x36D980 Offset: 0x36DA81 VA: 0x36D980
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x36DE20 Offset: 0x36DF21 VA: 0x36DE20
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x36E2F0 Offset: 0x36E3F1 VA: 0x36E2F0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x36E870 Offset: 0x36E971 VA: 0x36E870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x36ED30 Offset: 0x36EE31 VA: 0x36ED30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF0 Offset: 0x36CCF1 VA: 0x36CBF0
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x36D060 Offset: 0x36D161 VA: 0x36D060
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x36D4F0 Offset: 0x36D5F1 VA: 0x36D4F0
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x36D990 Offset: 0x36DA91 VA: 0x36D990
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x36DE30 Offset: 0x36DF31 VA: 0x36DE30
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x36E300 Offset: 0x36E401 VA: 0x36E300
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x36E880 Offset: 0x36E981 VA: 0x36E880
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x36ED40 Offset: 0x36EE41 VA: 0x36ED40
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC00 Offset: 0x36CD01 VA: 0x36CC00
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x36D070 Offset: 0x36D171 VA: 0x36D070
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x36D500 Offset: 0x36D601 VA: 0x36D500
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x36D9A0 Offset: 0x36DAA1 VA: 0x36D9A0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x36DE40 Offset: 0x36DF41 VA: 0x36DE40
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x36E310 Offset: 0x36E411 VA: 0x36E310
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x36E890 Offset: 0x36E991 VA: 0x36E890
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x36ED50 Offset: 0x36EE51 VA: 0x36ED50
	|-TMP_TextProcessingStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC10 Offset: 0x36CD11 VA: 0x36CC10
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x36D080 Offset: 0x36D181 VA: 0x36D080
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|
	|-RVA: 0x36D510 Offset: 0x36D611 VA: 0x36D510
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x36D9B0 Offset: 0x36DAB1 VA: 0x36D9B0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x36DE50 Offset: 0x36DF51 VA: 0x36DE50
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x36E320 Offset: 0x36E421 VA: 0x36E320
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x36E8A0 Offset: 0x36E9A1 VA: 0x36E8A0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x36ED60 Offset: 0x36EE61 VA: 0x36ED60
	|-TMP_TextProcessingStack<Color32>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC20 Offset: 0x36CD21 VA: 0x36CC20
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x36D090 Offset: 0x36D191 VA: 0x36D090
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|
	|-RVA: 0x36D520 Offset: 0x36D621 VA: 0x36D520
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x36D9C0 Offset: 0x36DAC1 VA: 0x36D9C0
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x36DE90 Offset: 0x36DF91 VA: 0x36DE90
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x36E370 Offset: 0x36E471 VA: 0x36E370
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x36E8F0 Offset: 0x36E9F1 VA: 0x36E8F0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x36ED70 Offset: 0x36EE71 VA: 0x36ED70
	|-TMP_TextProcessingStack<Color32>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC80 Offset: 0x36CD81 VA: 0x36CC80
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x36D0F0 Offset: 0x36D1F1 VA: 0x36D0F0
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|
	|-RVA: 0x36D590 Offset: 0x36D691 VA: 0x36D590
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x36DA20 Offset: 0x36DB21 VA: 0x36DA20
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x36DF20 Offset: 0x36E021 VA: 0x36DF20
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x36E450 Offset: 0x36E551 VA: 0x36E450
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x36E9A0 Offset: 0x36EAA1 VA: 0x36E9A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x36EDD0 Offset: 0x36EED1 VA: 0x36EDD0
	|-TMP_TextProcessingStack<Color32>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC90 Offset: 0x36CD91 VA: 0x36CC90
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x36D100 Offset: 0x36D201 VA: 0x36D100
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x36D5A0 Offset: 0x36D6A1 VA: 0x36D5A0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x36DA30 Offset: 0x36DB31 VA: 0x36DA30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x36DF30 Offset: 0x36E031 VA: 0x36DF30
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x36E460 Offset: 0x36E561 VA: 0x36E460
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x36E9B0 Offset: 0x36EAB1 VA: 0x36E9B0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x36EDF0 Offset: 0x36EEF1 VA: 0x36EDF0
	|-TMP_TextProcessingStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCA0 Offset: 0x36CDA1 VA: 0x36CCA0
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x36D110 Offset: 0x36D211 VA: 0x36D110
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x36D5B0 Offset: 0x36D6B1 VA: 0x36D5B0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x36DA40 Offset: 0x36DB41 VA: 0x36DA40
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x36DF70 Offset: 0x36E071 VA: 0x36DF70
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x36E4B0 Offset: 0x36E5B1 VA: 0x36E4B0
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x36EA00 Offset: 0x36EB01 VA: 0x36EA00
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x36EE00 Offset: 0x36EF01 VA: 0x36EE00
	|-TMP_TextProcessingStack<Color32>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD40 Offset: 0x36CE41 VA: 0x36CD40
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x36D1B0 Offset: 0x36D2B1 VA: 0x36D1B0
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|
	|-RVA: 0x36D670 Offset: 0x36D771 VA: 0x36D670
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x36DAE0 Offset: 0x36DBE1 VA: 0x36DAE0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x36DF80 Offset: 0x36E081 VA: 0x36DF80
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x36E4C0 Offset: 0x36E5C1 VA: 0x36E4C0
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x36EA10 Offset: 0x36EB11 VA: 0x36EA10
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x36EEA0 Offset: 0x36EFA1 VA: 0x36EEA0
	|-TMP_TextProcessingStack<Color32>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CDA0 Offset: 0x36CEA1 VA: 0x36CDA0
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x36D210 Offset: 0x36D311 VA: 0x36D210
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x36D6D0 Offset: 0x36D7D1 VA: 0x36D6D0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x36DB40 Offset: 0x36DC41 VA: 0x36DB40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x36E000 Offset: 0x36E101 VA: 0x36E000
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x36E550 Offset: 0x36E651 VA: 0x36E550
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x36EA80 Offset: 0x36EB81 VA: 0x36EA80
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x36EF00 Offset: 0x36F001 VA: 0x36EF00
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE10 Offset: 0x36CF11 VA: 0x36CE10
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x36D280 Offset: 0x36D381 VA: 0x36D280
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x36D740 Offset: 0x36D841 VA: 0x36D740
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x36DBB0 Offset: 0x36DCB1 VA: 0x36DBB0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x36E070 Offset: 0x36E171 VA: 0x36E070
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x36E5D0 Offset: 0x36E6D1 VA: 0x36E5D0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x36EAF0 Offset: 0x36EBF1 VA: 0x36EAF0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x36EF70 Offset: 0x36F071 VA: 0x36EF70
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	*/
}

[DebuggerDisplayAttribute] // RVA: 0x13EE60 Offset: 0x13EF61 VA: 0x13EE60
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5876
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA10 Offset: 0x36CB11 VA: 0x36CA10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CE80 Offset: 0x36CF81 VA: 0x36CE80
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|
	|-RVA: 0x36D2F0 Offset: 0x36D3F1 VA: 0x36D2F0
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x36D7B0 Offset: 0x36D8B1 VA: 0x36D7B0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC20 Offset: 0x36DD21 VA: 0x36DC20
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E0E0 Offset: 0x36E1E1 VA: 0x36E0E0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E650 Offset: 0x36E751 VA: 0x36E650
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EB60 Offset: 0x36EC61 VA: 0x36EB60
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CA50 Offset: 0x36CB51 VA: 0x36CA50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CEC0 Offset: 0x36CFC1 VA: 0x36CEC0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|
	|-RVA: 0x36D340 Offset: 0x36D441 VA: 0x36D340
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D7F0 Offset: 0x36D8F1 VA: 0x36D7F0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DC70 Offset: 0x36DD71 VA: 0x36DC70
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E130 Offset: 0x36E231 VA: 0x36E130
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E6B0 Offset: 0x36E7B1 VA: 0x36E6B0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EBA0 Offset: 0x36ECA1 VA: 0x36EBA0
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CAD0 Offset: 0x36CBD1 VA: 0x36CAD0
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x36CF40 Offset: 0x36D041 VA: 0x36CF40
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x36D3D0 Offset: 0x36D4D1 VA: 0x36D3D0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x36D870 Offset: 0x36D971 VA: 0x36D870
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x36DD00 Offset: 0x36DE01 VA: 0x36DD00
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x36E1C0 Offset: 0x36E2C1 VA: 0x36E1C0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x36E750 Offset: 0x36E851 VA: 0x36E750
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x36EC20 Offset: 0x36ED21 VA: 0x36EC20
	|-TMP_TextProcessingStack<Color32>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB60 Offset: 0x36CC61 VA: 0x36CB60
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x36CFD0 Offset: 0x36D0D1 VA: 0x36CFD0
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x36D460 Offset: 0x36D561 VA: 0x36D460
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x36D900 Offset: 0x36DA01 VA: 0x36D900
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x36DDA0 Offset: 0x36DEA1 VA: 0x36DDA0
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x36E260 Offset: 0x36E361 VA: 0x36E260
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x36E7F0 Offset: 0x36E8F1 VA: 0x36E7F0
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x36ECB0 Offset: 0x36EDB1 VA: 0x36ECB0
	|-TMP_TextProcessingStack<Color32>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CB70 Offset: 0x36CC71 VA: 0x36CB70
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x36CFE0 Offset: 0x36D0E1 VA: 0x36CFE0
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x36D470 Offset: 0x36D571 VA: 0x36D470
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x36D910 Offset: 0x36DA11 VA: 0x36D910
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x36DDB0 Offset: 0x36DEB1 VA: 0x36DDB0
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x36E270 Offset: 0x36E371 VA: 0x36E270
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x36E800 Offset: 0x36E901 VA: 0x36E800
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x36ECC0 Offset: 0x36EDC1 VA: 0x36ECC0
	|-TMP_TextProcessingStack<Color32>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBE0 Offset: 0x36CCE1 VA: 0x36CBE0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x36D050 Offset: 0x36D151 VA: 0x36D050
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x36D4E0 Offset: 0x36D5E1 VA: 0x36D4E0
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x36D980 Offset: 0x36DA81 VA: 0x36D980
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x36DE20 Offset: 0x36DF21 VA: 0x36DE20
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x36E2F0 Offset: 0x36E3F1 VA: 0x36E2F0
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x36E870 Offset: 0x36E971 VA: 0x36E870
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x36ED30 Offset: 0x36EE31 VA: 0x36ED30
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CBF0 Offset: 0x36CCF1 VA: 0x36CBF0
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x36D060 Offset: 0x36D161 VA: 0x36D060
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x36D4F0 Offset: 0x36D5F1 VA: 0x36D4F0
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x36D990 Offset: 0x36DA91 VA: 0x36D990
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x36DE30 Offset: 0x36DF31 VA: 0x36DE30
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x36E300 Offset: 0x36E401 VA: 0x36E300
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x36E880 Offset: 0x36E981 VA: 0x36E880
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x36ED40 Offset: 0x36EE41 VA: 0x36ED40
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC00 Offset: 0x36CD01 VA: 0x36CC00
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x36D070 Offset: 0x36D171 VA: 0x36D070
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x36D500 Offset: 0x36D601 VA: 0x36D500
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x36D9A0 Offset: 0x36DAA1 VA: 0x36D9A0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x36DE40 Offset: 0x36DF41 VA: 0x36DE40
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x36E310 Offset: 0x36E411 VA: 0x36E310
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x36E890 Offset: 0x36E991 VA: 0x36E890
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x36ED50 Offset: 0x36EE51 VA: 0x36ED50
	|-TMP_TextProcessingStack<Color32>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC10 Offset: 0x36CD11 VA: 0x36CC10
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x36D080 Offset: 0x36D181 VA: 0x36D080
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|
	|-RVA: 0x36D510 Offset: 0x36D611 VA: 0x36D510
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x36D9B0 Offset: 0x36DAB1 VA: 0x36D9B0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x36DE50 Offset: 0x36DF51 VA: 0x36DE50
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x36E320 Offset: 0x36E421 VA: 0x36E320
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x36E8A0 Offset: 0x36E9A1 VA: 0x36E8A0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x36ED60 Offset: 0x36EE61 VA: 0x36ED60
	|-TMP_TextProcessingStack<Color32>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC20 Offset: 0x36CD21 VA: 0x36CC20
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x36D090 Offset: 0x36D191 VA: 0x36D090
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|
	|-RVA: 0x36D520 Offset: 0x36D621 VA: 0x36D520
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x36D9C0 Offset: 0x36DAC1 VA: 0x36D9C0
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x36DE90 Offset: 0x36DF91 VA: 0x36DE90
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x36E370 Offset: 0x36E471 VA: 0x36E370
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x36E8F0 Offset: 0x36E9F1 VA: 0x36E8F0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x36ED70 Offset: 0x36EE71 VA: 0x36ED70
	|-TMP_TextProcessingStack<Color32>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC80 Offset: 0x36CD81 VA: 0x36CC80
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x36D0F0 Offset: 0x36D1F1 VA: 0x36D0F0
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|
	|-RVA: 0x36D590 Offset: 0x36D691 VA: 0x36D590
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x36DA20 Offset: 0x36DB21 VA: 0x36DA20
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x36DF20 Offset: 0x36E021 VA: 0x36DF20
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x36E450 Offset: 0x36E551 VA: 0x36E450
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x36E9A0 Offset: 0x36EAA1 VA: 0x36E9A0
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x36EDD0 Offset: 0x36EED1 VA: 0x36EDD0
	|-TMP_TextProcessingStack<Color32>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CC90 Offset: 0x36CD91 VA: 0x36CC90
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x36D100 Offset: 0x36D201 VA: 0x36D100
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x36D5A0 Offset: 0x36D6A1 VA: 0x36D5A0
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x36DA30 Offset: 0x36DB31 VA: 0x36DA30
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x36DF30 Offset: 0x36E031 VA: 0x36DF30
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x36E460 Offset: 0x36E561 VA: 0x36E460
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x36E9B0 Offset: 0x36EAB1 VA: 0x36E9B0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x36EDF0 Offset: 0x36EEF1 VA: 0x36EDF0
	|-TMP_TextProcessingStack<Color32>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CCA0 Offset: 0x36CDA1 VA: 0x36CCA0
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x36D110 Offset: 0x36D211 VA: 0x36D110
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x36D5B0 Offset: 0x36D6B1 VA: 0x36D5B0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x36DA40 Offset: 0x36DB41 VA: 0x36DA40
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x36DF70 Offset: 0x36E071 VA: 0x36DF70
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x36E4B0 Offset: 0x36E5B1 VA: 0x36E4B0
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x36EA00 Offset: 0x36EB01 VA: 0x36EA00
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x36EE00 Offset: 0x36EF01 VA: 0x36EE00
	|-TMP_TextProcessingStack<Color32>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CD40 Offset: 0x36CE41 VA: 0x36CD40
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x36D1B0 Offset: 0x36D2B1 VA: 0x36D1B0
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|
	|-RVA: 0x36D670 Offset: 0x36D771 VA: 0x36D670
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x36DAE0 Offset: 0x36DBE1 VA: 0x36DAE0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x36DF80 Offset: 0x36E081 VA: 0x36DF80
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x36E4C0 Offset: 0x36E5C1 VA: 0x36E4C0
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x36EA10 Offset: 0x36EB11 VA: 0x36EA10
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x36EEA0 Offset: 0x36EFA1 VA: 0x36EEA0
	|-TMP_TextProcessingStack<Color32>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CDA0 Offset: 0x36CEA1 VA: 0x36CDA0
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x36D210 Offset: 0x36D311 VA: 0x36D210
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x36D6D0 Offset: 0x36D7D1 VA: 0x36D6D0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x36DB40 Offset: 0x36DC41 VA: 0x36DB40
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x36E000 Offset: 0x36E101 VA: 0x36E000
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x36E550 Offset: 0x36E651 VA: 0x36E550
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x36EA80 Offset: 0x36EB81 VA: 0x36EA80
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x36EF00 Offset: 0x36F001 VA: 0x36EF00
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36CE10 Offset: 0x36CF11 VA: 0x36CE10
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x36D280 Offset: 0x36D381 VA: 0x36D280
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x36D740 Offset: 0x36D841 VA: 0x36D740
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x36DBB0 Offset: 0x36DCB1 VA: 0x36DBB0
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x36E070 Offset: 0x36E171 VA: 0x36E070
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x36E5D0 Offset: 0x36E6D1 VA: 0x36E5D0
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x36EAF0 Offset: 0x36EBF1 VA: 0x36EAF0
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x36EF70 Offset: 0x36F071 VA: 0x36EF70
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	*/
}

