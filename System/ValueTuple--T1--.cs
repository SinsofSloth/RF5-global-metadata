[Serializable]
public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple // TypeDefIndex: 112
{
	// Fields
	public T1 Item1; // 0x0

	// Properties
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383D30 Offset: 0x383E31 VA: 0x383D30
	|-ValueTuple<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383D40 Offset: 0x383E41 VA: 0x383D40
	|-ValueTuple<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383D50 Offset: 0x383E51 VA: 0x383D50
	|-ValueTuple<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383E00 Offset: 0x383F01 VA: 0x383E00
	|-ValueTuple<object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private int System.IComparable.CompareTo(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383E10 Offset: 0x383F11 VA: 0x383E10
	|-ValueTuple<object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int CompareTo(ValueTuple<T1> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383E20 Offset: 0x383F21 VA: 0x383E20
	|-ValueTuple<object>.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383ED0 Offset: 0x383FD1 VA: 0x383ED0
	|-ValueTuple<object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383EE0 Offset: 0x383FE1 VA: 0x383EE0
	|-ValueTuple<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383F00 Offset: 0x384001 VA: 0x383F00
	|-ValueTuple<object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.IValueTupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x383FD0 Offset: 0x3840D1 VA: 0x383FD0
	|-ValueTuple<object>.System.IValueTupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3840A0 Offset: 0x3841A1 VA: 0x3840A0
	|-ValueTuple<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private string System.IValueTupleInternal.ToStringEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384120 Offset: 0x384221 VA: 0x384120
	|-ValueTuple<object>.System.IValueTupleInternal.ToStringEnd
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384190 Offset: 0x384291 VA: 0x384190
	|-ValueTuple<object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

