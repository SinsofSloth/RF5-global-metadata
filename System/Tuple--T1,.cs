[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 134
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0
	private readonly T5 m_Item5; // 0x0
	private readonly T6 m_Item6; // 0x0
	private readonly T7 m_Item7; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	public T5 Item5 { get; }
	public T6 Item6 { get; }
	public T7 Item7 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BC60 Offset: 0x2B9BD61 VA: 0x2B9BC60
	|-Tuple<object, object, object, object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BC70 Offset: 0x2B9BD71 VA: 0x2B9BC70
	|-Tuple<object, object, object, object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BC80 Offset: 0x2B9BD81 VA: 0x2B9BC80
	|-Tuple<object, object, object, object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BC90 Offset: 0x2B9BD91 VA: 0x2B9BC90
	|-Tuple<object, object, object, object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public T5 get_Item5() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BCA0 Offset: 0x2B9BDA1 VA: 0x2B9BCA0
	|-Tuple<object, object, object, object, object, object, object>.get_Item5
	*/

	// RVA: -1 Offset: -1
	public T6 get_Item6() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BCB0 Offset: 0x2B9BDB1 VA: 0x2B9BCB0
	|-Tuple<object, object, object, object, object, object, object>.get_Item6
	*/

	// RVA: -1 Offset: -1
	public T7 get_Item7() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BCC0 Offset: 0x2B9BDC1 VA: 0x2B9BCC0
	|-Tuple<object, object, object, object, object, object, object>.get_Item7
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BCD0 Offset: 0x2B9BDD1 VA: 0x2B9BCD0
	|-Tuple<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BDA0 Offset: 0x2B9BEA1 VA: 0x2B9BDA0
	|-Tuple<object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BE90 Offset: 0x2B9BF91 VA: 0x2B9BE90
	|-Tuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9C270 Offset: 0x2B9C371 VA: 0x2B9C270
	|-Tuple<object, object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9C360 Offset: 0x2B9C461 VA: 0x2B9C360
	|-Tuple<object, object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9C7D0 Offset: 0x2B9C8D1 VA: 0x2B9C7D0
	|-Tuple<object, object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9C8B0 Offset: 0x2B9C9B1 VA: 0x2B9C8B0
	|-Tuple<object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CC50 Offset: 0x2B9CD51 VA: 0x2B9CC50
	|-Tuple<object, object, object, object, object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CD10 Offset: 0x2B9CE11 VA: 0x2B9CD10
	|-Tuple<object, object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CE00 Offset: 0x2B9CF01 VA: 0x2B9CE00
	|-Tuple<object, object, object, object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CF50 Offset: 0x2B9D051 VA: 0x2B9CF50
	|-Tuple<object, object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

