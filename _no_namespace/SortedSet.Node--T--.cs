[Serializable]
internal sealed class SortedSet.Node<T> // TypeDefIndex: 2094
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBD020 Offset: 0xBD121 VA: 0xBD020
	private T <Item>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD030 Offset: 0xBD131 VA: 0xBD030
	private SortedSet.Node<T> <Left>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD040 Offset: 0xBD141 VA: 0xBD040
	private SortedSet.Node<T> <Right>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xBD050 Offset: 0xBD151 VA: 0xBD050
	private NodeColor <Color>k__BackingField; // 0x0

	// Properties
	public T Item { get; set; }
	public SortedSet.Node<T> Left { get; set; }
	public SortedSet.Node<T> Right { get; set; }
	public NodeColor Color { get; set; }
	public bool IsBlack { get; }
	public bool IsRed { get; }
	public bool Is2Node { get; }
	public bool Is4Node { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T item, NodeColor color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7040 Offset: 0x2BB7141 VA: 0x2BB7040
	|-SortedSet.Node<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2BB7C00 Offset: 0x2BB7D01 VA: 0x2BB7C00
	|-SortedSet.Node<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static bool IsNonNullRed(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB70D0 Offset: 0x2BB71D1 VA: 0x2BB70D0
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNonNullRed
	|
	|-RVA: 0x2BB7C80 Offset: 0x2BB7D81 VA: 0x2BB7C80
	|-SortedSet.Node<object>.IsNonNullRed
	*/

	// RVA: -1 Offset: -1
	public static bool IsNullOrBlack(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7160 Offset: 0x2BB7261 VA: 0x2BB7160
	|-SortedSet.Node<KeyValuePair<object, object>>.IsNullOrBlack
	|
	|-RVA: 0x2BB7D10 Offset: 0x2BB7E11 VA: 0x2BB7D10
	|-SortedSet.Node<object>.IsNullOrBlack
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC50 Offset: 0xBDD51 VA: 0xBDC50
	// RVA: -1 Offset: -1
	public T get_Item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB71F0 Offset: 0x2BB72F1 VA: 0x2BB71F0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Item
	|
	|-RVA: 0x2BB7DA0 Offset: 0x2BB7EA1 VA: 0x2BB7DA0
	|-SortedSet.Node<object>.get_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC60 Offset: 0xBDD61 VA: 0xBDC60
	// RVA: -1 Offset: -1
	public void set_Item(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7200 Offset: 0x2BB7301 VA: 0x2BB7200
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Item
	|
	|-RVA: 0x2BB7DB0 Offset: 0x2BB7EB1 VA: 0x2BB7DB0
	|-SortedSet.Node<object>.set_Item
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC70 Offset: 0xBDD71 VA: 0xBDC70
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Left() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7210 Offset: 0x2BB7311 VA: 0x2BB7210
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Left
	|
	|-RVA: 0x2BB7DC0 Offset: 0x2BB7EC1 VA: 0x2BB7DC0
	|-SortedSet.Node<object>.get_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC80 Offset: 0xBDD81 VA: 0xBDC80
	// RVA: -1 Offset: -1
	public void set_Left(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7220 Offset: 0x2BB7321 VA: 0x2BB7220
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Left
	|
	|-RVA: 0x2BB7DD0 Offset: 0x2BB7ED1 VA: 0x2BB7DD0
	|-SortedSet.Node<object>.set_Left
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDC90 Offset: 0xBDD91 VA: 0xBDC90
	// RVA: -1 Offset: -1
	public SortedSet.Node<T> get_Right() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7230 Offset: 0x2BB7331 VA: 0x2BB7230
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Right
	|
	|-RVA: 0x2BB7DE0 Offset: 0x2BB7EE1 VA: 0x2BB7DE0
	|-SortedSet.Node<object>.get_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDCA0 Offset: 0xBDDA1 VA: 0xBDCA0
	// RVA: -1 Offset: -1
	public void set_Right(SortedSet.Node<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7240 Offset: 0x2BB7341 VA: 0x2BB7240
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Right
	|
	|-RVA: 0x2BB7DF0 Offset: 0x2BB7EF1 VA: 0x2BB7DF0
	|-SortedSet.Node<object>.set_Right
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDCB0 Offset: 0xBDDB1 VA: 0xBDCB0
	// RVA: -1 Offset: -1
	public NodeColor get_Color() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7250 Offset: 0x2BB7351 VA: 0x2BB7250
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Color
	|
	|-RVA: 0x2BB7E00 Offset: 0x2BB7F01 VA: 0x2BB7E00
	|-SortedSet.Node<object>.get_Color
	*/

	[CompilerGeneratedAttribute] // RVA: 0xBDCC0 Offset: 0xBDDC1 VA: 0xBDCC0
	// RVA: -1 Offset: -1
	public void set_Color(NodeColor value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7260 Offset: 0x2BB7361 VA: 0x2BB7260
	|-SortedSet.Node<KeyValuePair<object, object>>.set_Color
	|
	|-RVA: 0x2BB7E10 Offset: 0x2BB7F11 VA: 0x2BB7E10
	|-SortedSet.Node<object>.set_Color
	*/

	// RVA: -1 Offset: -1
	public bool get_IsBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7270 Offset: 0x2BB7371 VA: 0x2BB7270
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsBlack
	|
	|-RVA: 0x2BB7E20 Offset: 0x2BB7F21 VA: 0x2BB7E20
	|-SortedSet.Node<object>.get_IsBlack
	*/

	// RVA: -1 Offset: -1
	public bool get_IsRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB72B0 Offset: 0x2BB73B1 VA: 0x2BB72B0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_IsRed
	|
	|-RVA: 0x2BB7E60 Offset: 0x2BB7F61 VA: 0x2BB7E60
	|-SortedSet.Node<object>.get_IsRed
	*/

	// RVA: -1 Offset: -1
	public bool get_Is2Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB72F0 Offset: 0x2BB73F1 VA: 0x2BB72F0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is2Node
	|
	|-RVA: 0x2BB7EA0 Offset: 0x2BB7FA1 VA: 0x2BB7EA0
	|-SortedSet.Node<object>.get_Is2Node
	*/

	// RVA: -1 Offset: -1
	public bool get_Is4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB73A0 Offset: 0x2BB74A1 VA: 0x2BB73A0
	|-SortedSet.Node<KeyValuePair<object, object>>.get_Is4Node
	|
	|-RVA: 0x2BB7F50 Offset: 0x2BB8051 VA: 0x2BB7F50
	|-SortedSet.Node<object>.get_Is4Node
	*/

	// RVA: -1 Offset: -1
	public void ColorBlack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7430 Offset: 0x2BB7531 VA: 0x2BB7430
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorBlack
	|
	|-RVA: 0x2BB7FE0 Offset: 0x2BB80E1 VA: 0x2BB7FE0
	|-SortedSet.Node<object>.ColorBlack
	*/

	// RVA: -1 Offset: -1
	public void ColorRed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7460 Offset: 0x2BB7561 VA: 0x2BB7460
	|-SortedSet.Node<KeyValuePair<object, object>>.ColorRed
	|
	|-RVA: 0x2BB8010 Offset: 0x2BB8111 VA: 0x2BB8010
	|-SortedSet.Node<object>.ColorRed
	*/

	// RVA: -1 Offset: -1
	public TreeRotation GetRotation(SortedSet.Node<T> current, SortedSet.Node<T> sibling) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7490 Offset: 0x2BB7591 VA: 0x2BB7490
	|-SortedSet.Node<KeyValuePair<object, object>>.GetRotation
	|
	|-RVA: 0x2BB8040 Offset: 0x2BB8141 VA: 0x2BB8040
	|-SortedSet.Node<object>.GetRotation
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> GetSibling(SortedSet.Node<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7530 Offset: 0x2BB7631 VA: 0x2BB7530
	|-SortedSet.Node<KeyValuePair<object, object>>.GetSibling
	|
	|-RVA: 0x2BB80E0 Offset: 0x2BB81E1 VA: 0x2BB80E0
	|-SortedSet.Node<object>.GetSibling
	*/

	// RVA: -1 Offset: -1
	public void Split4Node() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB75A0 Offset: 0x2BB76A1 VA: 0x2BB75A0
	|-SortedSet.Node<KeyValuePair<object, object>>.Split4Node
	|
	|-RVA: 0x2BB8150 Offset: 0x2BB8251 VA: 0x2BB8150
	|-SortedSet.Node<object>.Split4Node
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> Rotate(TreeRotation rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7640 Offset: 0x2BB7741 VA: 0x2BB7640
	|-SortedSet.Node<KeyValuePair<object, object>>.Rotate
	|
	|-RVA: 0x2BB81F0 Offset: 0x2BB82F1 VA: 0x2BB81F0
	|-SortedSet.Node<object>.Rotate
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7780 Offset: 0x2BB7881 VA: 0x2BB7780
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeft
	|
	|-RVA: 0x2BB8330 Offset: 0x2BB8431 VA: 0x2BB8330
	|-SortedSet.Node<object>.RotateLeft
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateLeftRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7820 Offset: 0x2BB7921 VA: 0x2BB7820
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateLeftRight
	|
	|-RVA: 0x2BB83D0 Offset: 0x2BB84D1 VA: 0x2BB83D0
	|-SortedSet.Node<object>.RotateLeftRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRight() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7930 Offset: 0x2BB7A31 VA: 0x2BB7930
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRight
	|
	|-RVA: 0x2BB84E0 Offset: 0x2BB85E1 VA: 0x2BB84E0
	|-SortedSet.Node<object>.RotateRight
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Node<T> RotateRightLeft() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB79D0 Offset: 0x2BB7AD1 VA: 0x2BB79D0
	|-SortedSet.Node<KeyValuePair<object, object>>.RotateRightLeft
	|
	|-RVA: 0x2BB8580 Offset: 0x2BB8681 VA: 0x2BB8580
	|-SortedSet.Node<object>.RotateRightLeft
	*/

	// RVA: -1 Offset: -1
	public void Merge2Nodes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7AE0 Offset: 0x2BB7BE1 VA: 0x2BB7AE0
	|-SortedSet.Node<KeyValuePair<object, object>>.Merge2Nodes
	|
	|-RVA: 0x2BB8690 Offset: 0x2BB8791 VA: 0x2BB8690
	|-SortedSet.Node<object>.Merge2Nodes
	*/

	// RVA: -1 Offset: -1
	public void ReplaceChild(SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BB7B80 Offset: 0x2BB7C81 VA: 0x2BB7B80
	|-SortedSet.Node<KeyValuePair<object, object>>.ReplaceChild
	|
	|-RVA: 0x2BB8730 Offset: 0x2BB8831 VA: 0x2BB8730
	|-SortedSet.Node<object>.ReplaceChild
	*/
}

