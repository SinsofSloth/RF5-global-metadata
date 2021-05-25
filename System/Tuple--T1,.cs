[Serializable]
public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 129
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B94DD0 Offset: 0x2B94ED1 VA: 0x2B94DD0
	|-Tuple<Guid, string>.get_Item1
	|-Tuple<Guid, object>.get_Item1
	|
	|-RVA: 0x2B965B0 Offset: 0x2B966B1 VA: 0x2B965B0
	|-Tuple<Stream, Stream.ReadWriteTask>.get_Item1
	|-Tuple<TextWriter, string>.get_Item1
	|-Tuple<object, object>.get_Item1
	|
	|-RVA: 0x2B959C0 Offset: 0x2B95AC1 VA: 0x2B959C0
	|-Tuple<TextWriter, char>.get_Item1
	|-Tuple<object, char>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B94DE0 Offset: 0x2B94EE1 VA: 0x2B94DE0
	|-Tuple<Guid, string>.get_Item2
	|-Tuple<Guid, object>.get_Item2
	|
	|-RVA: 0x2B965C0 Offset: 0x2B966C1 VA: 0x2B965C0
	|-Tuple<Stream, Stream.ReadWriteTask>.get_Item2
	|-Tuple<TextWriter, string>.get_Item2
	|-Tuple<object, object>.get_Item2
	|
	|-RVA: 0x2B959D0 Offset: 0x2B95AD1 VA: 0x2B959D0
	|-Tuple<TextWriter, char>.get_Item2
	|-Tuple<object, char>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B94DF0 Offset: 0x2B94EF1 VA: 0x2B94DF0
	|-Tuple<Guid, object>..ctor
	|-Tuple<Guid, string>..ctor
	|
	|-RVA: 0x2B959E0 Offset: 0x2B95AE1 VA: 0x2B959E0
	|-Tuple<object, char>..ctor
	|
	|-RVA: 0x2B965D0 Offset: 0x2B966D1 VA: 0x2B965D0
	|-Tuple<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B94E40 Offset: 0x2B94F41 VA: 0x2B94E40
	|-Tuple<Guid, object>.Equals
	|
	|-RVA: 0x2B95A30 Offset: 0x2B95B31 VA: 0x2B95A30
	|-Tuple<object, char>.Equals
	|
	|-RVA: 0x2B96630 Offset: 0x2B96731 VA: 0x2B96630
	|-Tuple<object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B94F30 Offset: 0x2B95031 VA: 0x2B94F30
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2B95B20 Offset: 0x2B95C21 VA: 0x2B95B20
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2B96720 Offset: 0x2B96821 VA: 0x2B96720
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B95130 Offset: 0x2B95231 VA: 0x2B95130
	|-Tuple<Guid, object>.System.IComparable.CompareTo
	|
	|-RVA: 0x2B95D20 Offset: 0x2B95E21 VA: 0x2B95D20
	|-Tuple<object, char>.System.IComparable.CompareTo
	|
	|-RVA: 0x2B968C0 Offset: 0x2B969C1 VA: 0x2B968C0
	|-Tuple<object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B95220 Offset: 0x2B95321 VA: 0x2B95220
	|-Tuple<Guid, object>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2B95E10 Offset: 0x2B95F11 VA: 0x2B95E10
	|-Tuple<object, char>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2B969B0 Offset: 0x2B96AB1 VA: 0x2B969B0
	|-Tuple<object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B954A0 Offset: 0x2B955A1 VA: 0x2B954A0
	|-Tuple<Guid, object>.GetHashCode
	|
	|-RVA: 0x2B96090 Offset: 0x2B96191 VA: 0x2B96090
	|-Tuple<object, char>.GetHashCode
	|
	|-RVA: 0x2B96BE0 Offset: 0x2B96CE1 VA: 0x2B96BE0
	|-Tuple<object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B95580 Offset: 0x2B95681 VA: 0x2B95580
	|-Tuple<Guid, object>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2B96170 Offset: 0x2B96271 VA: 0x2B96170
	|-Tuple<object, char>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2B96CC0 Offset: 0x2B96DC1 VA: 0x2B96CC0
	|-Tuple<object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B95710 Offset: 0x2B95811 VA: 0x2B95710
	|-Tuple<Guid, object>.System.ITupleInternal.GetHashCode
	|
	|-RVA: 0x2B96300 Offset: 0x2B96401 VA: 0x2B96300
	|-Tuple<object, char>.System.ITupleInternal.GetHashCode
	|
	|-RVA: 0x2B96E10 Offset: 0x2B96F11 VA: 0x2B96E10
	|-Tuple<object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B957D0 Offset: 0x2B958D1 VA: 0x2B957D0
	|-Tuple<Guid, object>.ToString
	|
	|-RVA: 0x2B963C0 Offset: 0x2B964C1 VA: 0x2B963C0
	|-Tuple<object, char>.ToString
	|
	|-RVA: 0x2B96ED0 Offset: 0x2B96FD1 VA: 0x2B96ED0
	|-Tuple<object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B958C0 Offset: 0x2B959C1 VA: 0x2B958C0
	|-Tuple<Guid, object>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2B964B0 Offset: 0x2B965B1 VA: 0x2B964B0
	|-Tuple<object, char>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2B96FC0 Offset: 0x2B970C1 VA: 0x2B96FC0
	|-Tuple<object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B959B0 Offset: 0x2B95AB1 VA: 0x2B959B0
	|-Tuple<Guid, object>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2B965A0 Offset: 0x2B966A1 VA: 0x2B965A0
	|-Tuple<object, char>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2B97070 Offset: 0x2B97171 VA: 0x2B97070
	|-Tuple<object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 130
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97080 Offset: 0x2B97181 VA: 0x2B97080
	|-Tuple<object, object, object>.get_Item1
	|-Tuple<Task, Task, TaskContinuation>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97090 Offset: 0x2B97191 VA: 0x2B97090
	|-Tuple<object, object, object>.get_Item2
	|-Tuple<Task, Task, TaskContinuation>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B970A0 Offset: 0x2B971A1 VA: 0x2B970A0
	|-Tuple<object, object, object>.get_Item3
	|-Tuple<Task, Task, TaskContinuation>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B970B0 Offset: 0x2B971B1 VA: 0x2B970B0
	|-Tuple<object, object, object>..ctor
	|-Tuple<Task, Task, TaskContinuation>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97120 Offset: 0x2B97221 VA: 0x2B97120
	|-Tuple<object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97210 Offset: 0x2B97311 VA: 0x2B97210
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97420 Offset: 0x2B97521 VA: 0x2B97420
	|-Tuple<object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97510 Offset: 0x2B97611 VA: 0x2B97510
	|-Tuple<object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B977B0 Offset: 0x2B978B1 VA: 0x2B977B0
	|-Tuple<object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97890 Offset: 0x2B97991 VA: 0x2B97890
	|-Tuple<object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97A50 Offset: 0x2B97B51 VA: 0x2B97A50
	|-Tuple<object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97B10 Offset: 0x2B97C11 VA: 0x2B97B10
	|-Tuple<object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97C00 Offset: 0x2B97D01 VA: 0x2B97C00
	|-Tuple<object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97CD0 Offset: 0x2B97DD1 VA: 0x2B97CD0
	|-Tuple<object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 131
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97CE0 Offset: 0x2B97DE1 VA: 0x2B97CE0
	|-Tuple<TextReader, char[], int, int>.get_Item1
	|-Tuple<TextWriter, char[], int, int>.get_Item1
	|-Tuple<object, object, int, int>.get_Item1
	|
	|-RVA: 0x2B98D30 Offset: 0x2B98E31 VA: 0x2B98D30
	|-Tuple<object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97CF0 Offset: 0x2B97DF1 VA: 0x2B97CF0
	|-Tuple<TextReader, char[], int, int>.get_Item2
	|-Tuple<TextWriter, char[], int, int>.get_Item2
	|-Tuple<object, object, int, int>.get_Item2
	|
	|-RVA: 0x2B98D40 Offset: 0x2B98E41 VA: 0x2B98D40
	|-Tuple<object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97D00 Offset: 0x2B97E01 VA: 0x2B97D00
	|-Tuple<TextReader, char[], int, int>.get_Item3
	|-Tuple<TextWriter, char[], int, int>.get_Item3
	|-Tuple<object, object, int, int>.get_Item3
	|
	|-RVA: 0x2B98D50 Offset: 0x2B98E51 VA: 0x2B98D50
	|-Tuple<object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97D10 Offset: 0x2B97E11 VA: 0x2B97D10
	|-Tuple<TextReader, char[], int, int>.get_Item4
	|-Tuple<TextWriter, char[], int, int>.get_Item4
	|-Tuple<object, object, int, int>.get_Item4
	|
	|-RVA: 0x2B98D60 Offset: 0x2B98E61 VA: 0x2B98D60
	|-Tuple<object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97D20 Offset: 0x2B97E21 VA: 0x2B97D20
	|-Tuple<object, object, int, int>..ctor
	|
	|-RVA: 0x2B98D70 Offset: 0x2B98E71 VA: 0x2B98D70
	|-Tuple<object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97D90 Offset: 0x2B97E91 VA: 0x2B97D90
	|-Tuple<object, object, int, int>.Equals
	|
	|-RVA: 0x2B98E00 Offset: 0x2B98F01 VA: 0x2B98E00
	|-Tuple<object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B97E80 Offset: 0x2B97F81 VA: 0x2B97E80
	|-Tuple<object, object, int, int>.System.Collections.IStructuralEquatable.Equals
	|
	|-RVA: 0x2B98EF0 Offset: 0x2B98FF1 VA: 0x2B98EF0
	|-Tuple<object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B981C0 Offset: 0x2B982C1 VA: 0x2B981C0
	|-Tuple<object, object, int, int>.System.IComparable.CompareTo
	|
	|-RVA: 0x2B99170 Offset: 0x2B99271 VA: 0x2B99170
	|-Tuple<object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B982B0 Offset: 0x2B983B1 VA: 0x2B982B0
	|-Tuple<object, object, int, int>.System.Collections.IStructuralComparable.CompareTo
	|
	|-RVA: 0x2B99260 Offset: 0x2B99361 VA: 0x2B99260
	|-Tuple<object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98680 Offset: 0x2B98781 VA: 0x2B98680
	|-Tuple<object, object, int, int>.GetHashCode
	|
	|-RVA: 0x2B99570 Offset: 0x2B99671 VA: 0x2B99570
	|-Tuple<object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98760 Offset: 0x2B98861 VA: 0x2B98760
	|-Tuple<object, object, int, int>.System.Collections.IStructuralEquatable.GetHashCode
	|
	|-RVA: 0x2B99650 Offset: 0x2B99751 VA: 0x2B99650
	|-Tuple<object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98A10 Offset: 0x2B98B11 VA: 0x2B98A10
	|-Tuple<object, object, int, int>.System.ITupleInternal.GetHashCode
	|
	|-RVA: 0x2B99890 Offset: 0x2B99991 VA: 0x2B99890
	|-Tuple<object, object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98AD0 Offset: 0x2B98BD1 VA: 0x2B98AD0
	|-Tuple<object, object, int, int>.ToString
	|
	|-RVA: 0x2B99950 Offset: 0x2B99A51 VA: 0x2B99950
	|-Tuple<object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98BC0 Offset: 0x2B98CC1 VA: 0x2B98BC0
	|-Tuple<object, object, int, int>.System.ITupleInternal.ToString
	|
	|-RVA: 0x2B99A40 Offset: 0x2B99B41 VA: 0x2B99A40
	|-Tuple<object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B98D20 Offset: 0x2B98E21 VA: 0x2B98D20
	|-Tuple<object, object, int, int>.System.Runtime.CompilerServices.ITuple.get_Length
	|
	|-RVA: 0x2B99B30 Offset: 0x2B99C31 VA: 0x2B99B30
	|-Tuple<object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public class Tuple<T1, T2, T3, T4, T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 132
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0
	private readonly T5 m_Item5; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	public T5 Item5 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B40 Offset: 0x2B99C41 VA: 0x2B99B40
	|-Tuple<object, object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B50 Offset: 0x2B99C51 VA: 0x2B99B50
	|-Tuple<object, object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B60 Offset: 0x2B99C61 VA: 0x2B99B60
	|-Tuple<object, object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B70 Offset: 0x2B99C71 VA: 0x2B99B70
	|-Tuple<object, object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public T5 get_Item5() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B80 Offset: 0x2B99C81 VA: 0x2B99B80
	|-Tuple<object, object, object, object, object>.get_Item5
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99B90 Offset: 0x2B99C91 VA: 0x2B99B90
	|-Tuple<object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99C30 Offset: 0x2B99D31 VA: 0x2B99C30
	|-Tuple<object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B99D20 Offset: 0x2B99E21 VA: 0x2B99D20
	|-Tuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A020 Offset: 0x2B9A121 VA: 0x2B9A020
	|-Tuple<object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A110 Offset: 0x2B9A211 VA: 0x2B9A110
	|-Tuple<object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A490 Offset: 0x2B9A591 VA: 0x2B9A490
	|-Tuple<object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A570 Offset: 0x2B9A671 VA: 0x2B9A570
	|-Tuple<object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A820 Offset: 0x2B9A921 VA: 0x2B9A820
	|-Tuple<object, object, object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A8E0 Offset: 0x2B9A9E1 VA: 0x2B9A8E0
	|-Tuple<object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9A9D0 Offset: 0x2B9AAD1 VA: 0x2B9A9D0
	|-Tuple<object, object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AAE0 Offset: 0x2B9ABE1 VA: 0x2B9AAE0
	|-Tuple<object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 133
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0
	private readonly T5 m_Item5; // 0x0
	private readonly T6 m_Item6; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	public T5 Item5 { get; }
	public T6 Item6 { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AAF0 Offset: 0x2B9ABF1 VA: 0x2B9AAF0
	|-Tuple<object, object, object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB00 Offset: 0x2B9AC01 VA: 0x2B9AB00
	|-Tuple<object, object, object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB10 Offset: 0x2B9AC11 VA: 0x2B9AB10
	|-Tuple<object, object, object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB20 Offset: 0x2B9AC21 VA: 0x2B9AB20
	|-Tuple<object, object, object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public T5 get_Item5() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB30 Offset: 0x2B9AC31 VA: 0x2B9AB30
	|-Tuple<object, object, object, object, object, object>.get_Item5
	*/

	// RVA: -1 Offset: -1
	public T6 get_Item6() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB40 Offset: 0x2B9AC41 VA: 0x2B9AB40
	|-Tuple<object, object, object, object, object, object>.get_Item6
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AB50 Offset: 0x2B9AC51 VA: 0x2B9AB50
	|-Tuple<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AC10 Offset: 0x2B9AD11 VA: 0x2B9AC10
	|-Tuple<object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9AD00 Offset: 0x2B9AE01 VA: 0x2B9AD00
	|-Tuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9B070 Offset: 0x2B9B171 VA: 0x2B9B070
	|-Tuple<object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9B160 Offset: 0x2B9B261 VA: 0x2B9B160
	|-Tuple<object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9B560 Offset: 0x2B9B661 VA: 0x2B9B560
	|-Tuple<object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9B640 Offset: 0x2B9B741 VA: 0x2B9B640
	|-Tuple<object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9B970 Offset: 0x2B9BA71 VA: 0x2B9B970
	|-Tuple<object, object, object, object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BA30 Offset: 0x2B9BB31 VA: 0x2B9BA30
	|-Tuple<object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BB20 Offset: 0x2B9BC21 VA: 0x2B9BB20
	|-Tuple<object, object, object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9BC50 Offset: 0x2B9BD51 VA: 0x2B9BC50
	|-Tuple<object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

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

[Serializable]
public class Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple // TypeDefIndex: 135
{
	// Fields
	private readonly T1 m_Item1; // 0x0
	private readonly T2 m_Item2; // 0x0
	private readonly T3 m_Item3; // 0x0
	private readonly T4 m_Item4; // 0x0
	private readonly T5 m_Item5; // 0x0
	private readonly T6 m_Item6; // 0x0
	private readonly T7 m_Item7; // 0x0
	private readonly TRest m_Rest; // 0x0

	// Properties
	public T1 Item1 { get; }
	public T2 Item2 { get; }
	public T3 Item3 { get; }
	public T4 Item4 { get; }
	public T5 Item5 { get; }
	public T6 Item6 { get; }
	public T7 Item7 { get; }
	public TRest Rest { get; }
	private int System.Runtime.CompilerServices.ITuple.Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T1 get_Item1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CF60 Offset: 0x2B9D061 VA: 0x2B9CF60
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item1
	*/

	// RVA: -1 Offset: -1
	public T2 get_Item2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CF70 Offset: 0x2B9D071 VA: 0x2B9CF70
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item2
	*/

	// RVA: -1 Offset: -1
	public T3 get_Item3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CF80 Offset: 0x2B9D081 VA: 0x2B9CF80
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item3
	*/

	// RVA: -1 Offset: -1
	public T4 get_Item4() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CF90 Offset: 0x2B9D091 VA: 0x2B9CF90
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item4
	*/

	// RVA: -1 Offset: -1
	public T5 get_Item5() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CFA0 Offset: 0x2B9D0A1 VA: 0x2B9CFA0
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item5
	*/

	// RVA: -1 Offset: -1
	public T6 get_Item6() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CFB0 Offset: 0x2B9D0B1 VA: 0x2B9CFB0
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item6
	*/

	// RVA: -1 Offset: -1
	public T7 get_Item7() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CFC0 Offset: 0x2B9D0C1 VA: 0x2B9CFC0
	|-Tuple<object, object, object, object, object, object, object, object>.get_Item7
	*/

	// RVA: -1 Offset: -1
	public TRest get_Rest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CFD0 Offset: 0x2B9D0D1 VA: 0x2B9CFD0
	|-Tuple<object, object, object, object, object, object, object, object>.get_Rest
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9CFE0 Offset: 0x2B9D0E1 VA: 0x2B9CFE0
	|-Tuple<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D150 Offset: 0x2B9D251 VA: 0x2B9D150
	|-Tuple<object, object, object, object, object, object, object, object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D240 Offset: 0x2B9D341 VA: 0x2B9D240
	|-Tuple<object, object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private int System.IComparable.CompareTo(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D690 Offset: 0x2B9D791 VA: 0x2B9D690
	|-Tuple<object, object, object, object, object, object, object, object>.System.IComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D780 Offset: 0x2B9D881 VA: 0x2B9D780
	|-Tuple<object, object, object, object, object, object, object, object>.System.Collections.IStructuralComparable.CompareTo
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DC60 Offset: 0x2B9DD61 VA: 0x2B9DC60
	|-Tuple<object, object, object, object, object, object, object, object>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DD40 Offset: 0x2B9DE41 VA: 0x2B9DD40
	|-Tuple<object, object, object, object, object, object, object, object>.System.Collections.IStructuralEquatable.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private int System.ITupleInternal.GetHashCode(IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F040 Offset: 0x2B9F141 VA: 0x2B9F040
	|-Tuple<object, object, object, object, object, object, object, object>.System.ITupleInternal.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F100 Offset: 0x2B9F201 VA: 0x2B9F100
	|-Tuple<object, object, object, object, object, object, object, object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private string System.ITupleInternal.ToString(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F1F0 Offset: 0x2B9F2F1 VA: 0x2B9F1F0
	|-Tuple<object, object, object, object, object, object, object, object>.System.ITupleInternal.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private int System.Runtime.CompilerServices.ITuple.get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9F3E0 Offset: 0x2B9F4E1 VA: 0x2B9F3E0
	|-Tuple<object, object, object, object, object, object, object, object>.System.Runtime.CompilerServices.ITuple.get_Length
	*/
}

