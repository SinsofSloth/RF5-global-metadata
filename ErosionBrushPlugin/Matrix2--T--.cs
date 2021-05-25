[DefaultMemberAttribute] // RVA: 0x1495B0 Offset: 0x1496B1 VA: 0x1495B0
public class Matrix2<T> : ICloneable // TypeDefIndex: 9729
{
	// Fields
	public T[] array; // 0x0
	public CoordRect rect; // 0x0
	public int pos; // 0x0
	public int count; // 0x0

	// Properties
	public T Item { get; set; }
	public T Item { get; set; }
	public T Item { get; set; }
	public T nextX { get; set; }
	public T prevX { get; set; }
	public T nextZ { get; set; }
	public T prevZ { get; set; }
	public T nextXnextZ { get; set; }
	public T prevXnextZ { get; set; }
	public T nextXprevZ { get; set; }
	public T prevXprevZ { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C916B0 Offset: 0x2C917B1 VA: 0x2C916B0
	|-Matrix2<bool>..ctor
	|
	|-RVA: 0x2C93310 Offset: 0x2C93411 VA: 0x2C93310
	|-Matrix2<object>..ctor
	|
	|-RVA: 0x2C94FC0 Offset: 0x2C950C1 VA: 0x2C94FC0
	|-Matrix2<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int x, int z, T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C916D0 Offset: 0x2C917D1 VA: 0x2C916D0
	|-Matrix2<bool>..ctor
	|
	|-RVA: 0x2C93330 Offset: 0x2C93431 VA: 0x2C93330
	|-Matrix2<object>..ctor
	|-Matrix2<float[,,]>..ctor
	|-Matrix2<float[,]>..ctor
	|
	|-RVA: 0x2C94FE0 Offset: 0x2C950E1 VA: 0x2C94FE0
	|-Matrix2<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CoordRect rect, T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91990 Offset: 0x2C91A91 VA: 0x2C91990
	|-Matrix2<bool>..ctor
	|
	|-RVA: 0x2C935F0 Offset: 0x2C936F1 VA: 0x2C935F0
	|-Matrix2<object>..ctor
	|-Matrix2<float[,,]>..ctor
	|-Matrix2<float[,]>..ctor
	|
	|-RVA: 0x2C952A0 Offset: 0x2C953A1 VA: 0x2C952A0
	|-Matrix2<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Coord offset, Coord size, T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91C30 Offset: 0x2C91D31 VA: 0x2C91C30
	|-Matrix2<bool>..ctor
	|
	|-RVA: 0x2C93890 Offset: 0x2C93991 VA: 0x2C93890
	|-Matrix2<object>..ctor
	|
	|-RVA: 0x2C95540 Offset: 0x2C95641 VA: 0x2C95540
	|-Matrix2<float>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91EF0 Offset: 0x2C91FF1 VA: 0x2C91EF0
	|-Matrix2<bool>.get_Item
	|
	|-RVA: 0x2C93B50 Offset: 0x2C93C51 VA: 0x2C93B50
	|-Matrix2<object>.get_Item
	|-Matrix2<float[,,]>.get_Item
	|-Matrix2<float[,]>.get_Item
	|
	|-RVA: 0x2C95800 Offset: 0x2C95901 VA: 0x2C95800
	|-Matrix2<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int x, int z, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91F40 Offset: 0x2C92041 VA: 0x2C91F40
	|-Matrix2<bool>.set_Item
	|
	|-RVA: 0x2C93BA0 Offset: 0x2C93CA1 VA: 0x2C93BA0
	|-Matrix2<object>.set_Item
	|-Matrix2<float[,,]>.set_Item
	|-Matrix2<float[,]>.set_Item
	|
	|-RVA: 0x2C95850 Offset: 0x2C95951 VA: 0x2C95850
	|-Matrix2<float>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T get_Item(Coord c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91FA0 Offset: 0x2C920A1 VA: 0x2C91FA0
	|-Matrix2<bool>.get_Item
	|
	|-RVA: 0x2C93C00 Offset: 0x2C93D01 VA: 0x2C93C00
	|-Matrix2<object>.get_Item
	|-Matrix2<float[,,]>.get_Item
	|-Matrix2<float[,]>.get_Item
	|
	|-RVA: 0x2C958A0 Offset: 0x2C959A1 VA: 0x2C958A0
	|-Matrix2<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(Coord c, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92000 Offset: 0x2C92101 VA: 0x2C92000
	|-Matrix2<bool>.set_Item
	|
	|-RVA: 0x2C93C60 Offset: 0x2C93D61 VA: 0x2C93C60
	|-Matrix2<object>.set_Item
	|-Matrix2<float[,,]>.set_Item
	|-Matrix2<float[,]>.set_Item
	|
	|-RVA: 0x2C95900 Offset: 0x2C95A01 VA: 0x2C95900
	|-Matrix2<float>.set_Item
	*/

	// RVA: -1 Offset: -1
	public T CheckGet(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92060 Offset: 0x2C92161 VA: 0x2C92060
	|-Matrix2<bool>.CheckGet
	|
	|-RVA: 0x2C93CC0 Offset: 0x2C93DC1 VA: 0x2C93CC0
	|-Matrix2<object>.CheckGet
	|
	|-RVA: 0x2C95960 Offset: 0x2C95A61 VA: 0x2C95960
	|-Matrix2<float>.CheckGet
	*/

	// RVA: -1 Offset: -1
	public T get_Item(Vector2 pos) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92120 Offset: 0x2C92221 VA: 0x2C92120
	|-Matrix2<bool>.get_Item
	|
	|-RVA: 0x2C93D70 Offset: 0x2C93E71 VA: 0x2C93D70
	|-Matrix2<object>.get_Item
	|
	|-RVA: 0x2C959F0 Offset: 0x2C95AF1 VA: 0x2C959F0
	|-Matrix2<float>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(Vector2 pos, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C921A0 Offset: 0x2C922A1 VA: 0x2C921A0
	|-Matrix2<bool>.set_Item
	|
	|-RVA: 0x2C93DF0 Offset: 0x2C93EF1 VA: 0x2C93DF0
	|-Matrix2<object>.set_Item
	|
	|-RVA: 0x2C95A70 Offset: 0x2C95B71 VA: 0x2C95A70
	|-Matrix2<float>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92220 Offset: 0x2C92321 VA: 0x2C92220
	|-Matrix2<bool>.Clear
	|
	|-RVA: 0x2C93E70 Offset: 0x2C93F71 VA: 0x2C93E70
	|-Matrix2<object>.Clear
	|
	|-RVA: 0x2C95AF0 Offset: 0x2C95BF1 VA: 0x2C95AF0
	|-Matrix2<float>.Clear
	*/

	// RVA: -1 Offset: -1
	public void ChangeRect(CoordRect newRect) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92280 Offset: 0x2C92381 VA: 0x2C92280
	|-Matrix2<bool>.ChangeRect
	|
	|-RVA: 0x2C93EF0 Offset: 0x2C93FF1 VA: 0x2C93EF0
	|-Matrix2<object>.ChangeRect
	|
	|-RVA: 0x2C95B50 Offset: 0x2C95C51 VA: 0x2C95B50
	|-Matrix2<float>.ChangeRect
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual object Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92310 Offset: 0x2C92411 VA: 0x2C92310
	|-Matrix2<bool>.Clone
	|
	|-RVA: 0x2C93F80 Offset: 0x2C94081 VA: 0x2C93F80
	|-Matrix2<object>.Clone
	|
	|-RVA: 0x2C95BE0 Offset: 0x2C95CE1 VA: 0x2C95BE0
	|-Matrix2<float>.Clone
	*/

	// RVA: -1 Offset: -1
	public Matrix2<T> Clone(Matrix2<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92340 Offset: 0x2C92441 VA: 0x2C92340
	|-Matrix2<bool>.Clone
	|
	|-RVA: 0x2C93FB0 Offset: 0x2C940B1 VA: 0x2C93FB0
	|-Matrix2<object>.Clone
	|
	|-RVA: 0x2C95C10 Offset: 0x2C95D11 VA: 0x2C95C10
	|-Matrix2<float>.Clone
	*/

	// RVA: -1 Offset: -1
	public void Fill(T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C924A0 Offset: 0x2C925A1 VA: 0x2C924A0
	|-Matrix2<bool>.Fill
	|
	|-RVA: 0x2C94120 Offset: 0x2C94221 VA: 0x2C94120
	|-Matrix2<object>.Fill
	|
	|-RVA: 0x2C95D70 Offset: 0x2C95E71 VA: 0x2C95D70
	|-Matrix2<float>.Fill
	*/

	// RVA: -1 Offset: -1
	public void Fill(Matrix2<T> m, bool removeBorders = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92510 Offset: 0x2C92611 VA: 0x2C92510
	|-Matrix2<bool>.Fill
	|
	|-RVA: 0x2C941B0 Offset: 0x2C942B1 VA: 0x2C941B0
	|-Matrix2<object>.Fill
	|
	|-RVA: 0x2C95DD0 Offset: 0x2C95ED1 VA: 0x2C95DD0
	|-Matrix2<float>.Fill
	*/

	// RVA: -1 Offset: -1
	public void SetPos(int x, int z) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92640 Offset: 0x2C92741 VA: 0x2C92640
	|-Matrix2<bool>.SetPos
	|
	|-RVA: 0x2C942E0 Offset: 0x2C943E1 VA: 0x2C942E0
	|-Matrix2<object>.SetPos
	|
	|-RVA: 0x2C95EF0 Offset: 0x2C95FF1 VA: 0x2C95EF0
	|-Matrix2<float>.SetPos
	*/

	// RVA: -1 Offset: -1
	public void SetPos(int x, int z, int s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92660 Offset: 0x2C92761 VA: 0x2C92660
	|-Matrix2<bool>.SetPos
	|
	|-RVA: 0x2C94300 Offset: 0x2C94401 VA: 0x2C94300
	|-Matrix2<object>.SetPos
	|
	|-RVA: 0x2C95F10 Offset: 0x2C96011 VA: 0x2C95F10
	|-Matrix2<float>.SetPos
	*/

	// RVA: -1 Offset: -1
	public void MoveX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92680 Offset: 0x2C92781 VA: 0x2C92680
	|-Matrix2<bool>.MoveX
	|
	|-RVA: 0x2C94320 Offset: 0x2C94421 VA: 0x2C94320
	|-Matrix2<object>.MoveX
	|
	|-RVA: 0x2C95F30 Offset: 0x2C96031 VA: 0x2C95F30
	|-Matrix2<float>.MoveX
	*/

	// RVA: -1 Offset: -1
	public void MoveZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92690 Offset: 0x2C92791 VA: 0x2C92690
	|-Matrix2<bool>.MoveZ
	|
	|-RVA: 0x2C94330 Offset: 0x2C94431 VA: 0x2C94330
	|-Matrix2<object>.MoveZ
	|
	|-RVA: 0x2C95F40 Offset: 0x2C96041 VA: 0x2C95F40
	|-Matrix2<float>.MoveZ
	*/

	// RVA: -1 Offset: -1
	public void MovePrevX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C926B0 Offset: 0x2C927B1 VA: 0x2C926B0
	|-Matrix2<bool>.MovePrevX
	|
	|-RVA: 0x2C94350 Offset: 0x2C94451 VA: 0x2C94350
	|-Matrix2<object>.MovePrevX
	|
	|-RVA: 0x2C95F60 Offset: 0x2C96061 VA: 0x2C95F60
	|-Matrix2<float>.MovePrevX
	*/

	// RVA: -1 Offset: -1
	public void MovePrevZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C926C0 Offset: 0x2C927C1 VA: 0x2C926C0
	|-Matrix2<bool>.MovePrevZ
	|
	|-RVA: 0x2C94360 Offset: 0x2C94461 VA: 0x2C94360
	|-Matrix2<object>.MovePrevZ
	|
	|-RVA: 0x2C95F70 Offset: 0x2C96071 VA: 0x2C95F70
	|-Matrix2<float>.MovePrevZ
	*/

	// RVA: -1 Offset: -1
	public T get_nextX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C926E0 Offset: 0x2C927E1 VA: 0x2C926E0
	|-Matrix2<bool>.get_nextX
	|
	|-RVA: 0x2C94380 Offset: 0x2C94481 VA: 0x2C94380
	|-Matrix2<object>.get_nextX
	|
	|-RVA: 0x2C95F90 Offset: 0x2C96091 VA: 0x2C95F90
	|-Matrix2<float>.get_nextX
	*/

	// RVA: -1 Offset: -1
	public void set_nextX(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92730 Offset: 0x2C92831 VA: 0x2C92730
	|-Matrix2<bool>.set_nextX
	|
	|-RVA: 0x2C943D0 Offset: 0x2C944D1 VA: 0x2C943D0
	|-Matrix2<object>.set_nextX
	|
	|-RVA: 0x2C95FE0 Offset: 0x2C960E1 VA: 0x2C95FE0
	|-Matrix2<float>.set_nextX
	*/

	// RVA: -1 Offset: -1
	public T get_prevX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92780 Offset: 0x2C92881 VA: 0x2C92780
	|-Matrix2<bool>.get_prevX
	|
	|-RVA: 0x2C94420 Offset: 0x2C94521 VA: 0x2C94420
	|-Matrix2<object>.get_prevX
	|
	|-RVA: 0x2C96030 Offset: 0x2C96131 VA: 0x2C96030
	|-Matrix2<float>.get_prevX
	*/

	// RVA: -1 Offset: -1
	public void set_prevX(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C927D0 Offset: 0x2C928D1 VA: 0x2C927D0
	|-Matrix2<bool>.set_prevX
	|
	|-RVA: 0x2C94470 Offset: 0x2C94571 VA: 0x2C94470
	|-Matrix2<object>.set_prevX
	|
	|-RVA: 0x2C96080 Offset: 0x2C96181 VA: 0x2C96080
	|-Matrix2<float>.set_prevX
	*/

	// RVA: -1 Offset: -1
	public T get_nextZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92820 Offset: 0x2C92921 VA: 0x2C92820
	|-Matrix2<bool>.get_nextZ
	|
	|-RVA: 0x2C944C0 Offset: 0x2C945C1 VA: 0x2C944C0
	|-Matrix2<object>.get_nextZ
	|
	|-RVA: 0x2C960D0 Offset: 0x2C961D1 VA: 0x2C960D0
	|-Matrix2<float>.get_nextZ
	*/

	// RVA: -1 Offset: -1
	public void set_nextZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92870 Offset: 0x2C92971 VA: 0x2C92870
	|-Matrix2<bool>.set_nextZ
	|
	|-RVA: 0x2C94510 Offset: 0x2C94611 VA: 0x2C94510
	|-Matrix2<object>.set_nextZ
	|
	|-RVA: 0x2C96120 Offset: 0x2C96221 VA: 0x2C96120
	|-Matrix2<float>.set_nextZ
	*/

	// RVA: -1 Offset: -1
	public T get_prevZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C928C0 Offset: 0x2C929C1 VA: 0x2C928C0
	|-Matrix2<bool>.get_prevZ
	|
	|-RVA: 0x2C94560 Offset: 0x2C94661 VA: 0x2C94560
	|-Matrix2<object>.get_prevZ
	|
	|-RVA: 0x2C96170 Offset: 0x2C96271 VA: 0x2C96170
	|-Matrix2<float>.get_prevZ
	*/

	// RVA: -1 Offset: -1
	public void set_prevZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92910 Offset: 0x2C92A11 VA: 0x2C92910
	|-Matrix2<bool>.set_prevZ
	|
	|-RVA: 0x2C945B0 Offset: 0x2C946B1 VA: 0x2C945B0
	|-Matrix2<object>.set_prevZ
	|
	|-RVA: 0x2C961C0 Offset: 0x2C962C1 VA: 0x2C961C0
	|-Matrix2<float>.set_prevZ
	*/

	// RVA: -1 Offset: -1
	public T get_nextXnextZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92960 Offset: 0x2C92A61 VA: 0x2C92960
	|-Matrix2<bool>.get_nextXnextZ
	|
	|-RVA: 0x2C94600 Offset: 0x2C94701 VA: 0x2C94600
	|-Matrix2<object>.get_nextXnextZ
	|
	|-RVA: 0x2C96210 Offset: 0x2C96311 VA: 0x2C96210
	|-Matrix2<float>.get_nextXnextZ
	*/

	// RVA: -1 Offset: -1
	public void set_nextXnextZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C929B0 Offset: 0x2C92AB1 VA: 0x2C929B0
	|-Matrix2<bool>.set_nextXnextZ
	|
	|-RVA: 0x2C94650 Offset: 0x2C94751 VA: 0x2C94650
	|-Matrix2<object>.set_nextXnextZ
	|
	|-RVA: 0x2C96260 Offset: 0x2C96361 VA: 0x2C96260
	|-Matrix2<float>.set_nextXnextZ
	*/

	// RVA: -1 Offset: -1
	public T get_prevXnextZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92A00 Offset: 0x2C92B01 VA: 0x2C92A00
	|-Matrix2<bool>.get_prevXnextZ
	|
	|-RVA: 0x2C946A0 Offset: 0x2C947A1 VA: 0x2C946A0
	|-Matrix2<object>.get_prevXnextZ
	|
	|-RVA: 0x2C962B0 Offset: 0x2C963B1 VA: 0x2C962B0
	|-Matrix2<float>.get_prevXnextZ
	*/

	// RVA: -1 Offset: -1
	public void set_prevXnextZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92A50 Offset: 0x2C92B51 VA: 0x2C92A50
	|-Matrix2<bool>.set_prevXnextZ
	|
	|-RVA: 0x2C946F0 Offset: 0x2C947F1 VA: 0x2C946F0
	|-Matrix2<object>.set_prevXnextZ
	|
	|-RVA: 0x2C96300 Offset: 0x2C96401 VA: 0x2C96300
	|-Matrix2<float>.set_prevXnextZ
	*/

	// RVA: -1 Offset: -1
	public T get_nextXprevZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92AA0 Offset: 0x2C92BA1 VA: 0x2C92AA0
	|-Matrix2<bool>.get_nextXprevZ
	|
	|-RVA: 0x2C94740 Offset: 0x2C94841 VA: 0x2C94740
	|-Matrix2<object>.get_nextXprevZ
	|
	|-RVA: 0x2C96350 Offset: 0x2C96451 VA: 0x2C96350
	|-Matrix2<float>.get_nextXprevZ
	*/

	// RVA: -1 Offset: -1
	public void set_nextXprevZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92AF0 Offset: 0x2C92BF1 VA: 0x2C92AF0
	|-Matrix2<bool>.set_nextXprevZ
	|
	|-RVA: 0x2C94790 Offset: 0x2C94891 VA: 0x2C94790
	|-Matrix2<object>.set_nextXprevZ
	|
	|-RVA: 0x2C963A0 Offset: 0x2C964A1 VA: 0x2C963A0
	|-Matrix2<float>.set_nextXprevZ
	*/

	// RVA: -1 Offset: -1
	public T get_prevXprevZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92B40 Offset: 0x2C92C41 VA: 0x2C92B40
	|-Matrix2<bool>.get_prevXprevZ
	|
	|-RVA: 0x2C947E0 Offset: 0x2C948E1 VA: 0x2C947E0
	|-Matrix2<object>.get_prevXprevZ
	|
	|-RVA: 0x2C963F0 Offset: 0x2C964F1 VA: 0x2C963F0
	|-Matrix2<float>.get_prevXprevZ
	*/

	// RVA: -1 Offset: -1
	public void set_prevXprevZ(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92B90 Offset: 0x2C92C91 VA: 0x2C92B90
	|-Matrix2<bool>.set_prevXprevZ
	|
	|-RVA: 0x2C94830 Offset: 0x2C94931 VA: 0x2C94830
	|-Matrix2<object>.set_prevXprevZ
	|
	|-RVA: 0x2C96440 Offset: 0x2C96541 VA: 0x2C96440
	|-Matrix2<float>.set_prevXprevZ
	*/

	// RVA: -1 Offset: -1
	public void RemoveBorders() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92BE0 Offset: 0x2C92CE1 VA: 0x2C92BE0
	|-Matrix2<bool>.RemoveBorders
	|
	|-RVA: 0x2C94880 Offset: 0x2C94981 VA: 0x2C94880
	|-Matrix2<object>.RemoveBorders
	|
	|-RVA: 0x2C96490 Offset: 0x2C96591 VA: 0x2C96490
	|-Matrix2<float>.RemoveBorders
	*/

	// RVA: -1 Offset: -1
	public void RemoveBorders(int borderMinX, int borderMinZ, int borderMaxX, int borderMaxZ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C92E40 Offset: 0x2C92F41 VA: 0x2C92E40
	|-Matrix2<bool>.RemoveBorders
	|
	|-RVA: 0x2C94AF0 Offset: 0x2C94BF1 VA: 0x2C94AF0
	|-Matrix2<object>.RemoveBorders
	|
	|-RVA: 0x2C966E0 Offset: 0x2C967E1 VA: 0x2C966E0
	|-Matrix2<float>.RemoveBorders
	*/

	// RVA: -1 Offset: -1
	public void RemoveBorders(CoordRect centerRect) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C931C0 Offset: 0x2C932C1 VA: 0x2C931C0
	|-Matrix2<bool>.RemoveBorders
	|
	|-RVA: 0x2C94E70 Offset: 0x2C94F71 VA: 0x2C94E70
	|-Matrix2<object>.RemoveBorders
	|
	|-RVA: 0x2C96A50 Offset: 0x2C96B51 VA: 0x2C96A50
	|-Matrix2<float>.RemoveBorders
	*/
}

