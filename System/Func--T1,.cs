[TypeForwardedFromAttribute] // RVA: 0xAB860 Offset: 0xAB961 VA: 0xAB860
public sealed class Func<T1, T2, TResult> : MulticastDelegate // TypeDefIndex: 159
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7D230 Offset: 0x2D7D331 VA: 0x2D7D230
	|-Func<DamageActionType, DamageResult, bool>..ctor
	|-Func<Int32Enum, DamageResult, bool>..ctor
	|
	|-RVA: 0x2D7DBB0 Offset: 0x2D7DCB1 VA: 0x2D7DBB0
	|-Func<HateController.HateParameter, int, int>..ctor
	|-Func<object, int, int>..ctor
	|
	|-RVA: 0x2D7E5C0 Offset: 0x2D7E6C1 VA: 0x2D7E5C0
	|-Func<Stream, IAsyncResult, int>..ctor
	|-Func<object, object, int>..ctor
	|
	|-RVA: 0x2D7EF00 Offset: 0x2D7F001 VA: 0x2D7EF00
	|-Func<Stream, IAsyncResult, VoidTaskResult>..ctor
	|-Func<object, object, VoidTaskResult>..ctor
	|
	|-RVA: 0x2D7CEB0 Offset: 0x2D7CFB1 VA: 0x2D7CEB0
	|-Func<int, ObjectSerializationInfo.EmittableMember, Action>..ctor
	|-Func<int, object, object>..ctor
	|
	|-RVA: 0x2D7C3A0 Offset: 0x2D7C4A1 VA: 0x2D7C3A0
	|-Func<int, int, bool>..ctor
	|
	|-RVA: 0x2D7C750 Offset: 0x2D7C851 VA: 0x2D7C750
	|-Func<int, int, int>..ctor
	|
	|-RVA: 0x2D7CAF0 Offset: 0x2D7CBF1 VA: 0x2D7CAF0
	|-Func<int, IntPtr, bool>..ctor
	|
	|-RVA: 0x2D7D7E0 Offset: 0x2D7D8E1 VA: 0x2D7D7E0
	|-Func<Int32Enum, object, bool>..ctor
	|
	|-RVA: 0x2D7E110 Offset: 0x2D7E211 VA: 0x2D7E110
	|-Func<object, object, bool>..ctor
	|
	|-RVA: 0x2D7EA70 Offset: 0x2D7EB71 VA: 0x2D7EA70
	|-Func<object, object, object>..ctor
	|
	|-RVA: 0x2D7F3C0 Offset: 0x2D7F4C1 VA: 0x2D7F3C0
	|-Func<float, float, bool>..ctor
	|
	|-RVA: 0x2D7F760 Offset: 0x2D7F861 VA: 0x2D7F760
	|-Func<float, float, float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7D250 Offset: 0x2D7D351 VA: 0x2D7D250
	|-Func<DamageActionType, DamageResult, bool>.Invoke
	|-Func<Int32Enum, DamageResult, bool>.Invoke
	|
	|-RVA: 0x2D7DBD0 Offset: 0x2D7DCD1 VA: 0x2D7DBD0
	|-Func<HateController.HateParameter, int, int>.Invoke
	|-Func<object, int, int>.Invoke
	|
	|-RVA: 0x2D7CED0 Offset: 0x2D7CFD1 VA: 0x2D7CED0
	|-Func<int, ObjectSerializationInfo.EmittableMember, Action>.Invoke
	|-Func<int, string, TMP_FontAsset>.Invoke
	|-Func<int, string, TMP_SpriteAsset>.Invoke
	|-Func<int, object, object>.Invoke
	|
	|-RVA: 0x2D7C3C0 Offset: 0x2D7C4C1 VA: 0x2D7C3C0
	|-Func<int, int, bool>.Invoke
	|
	|-RVA: 0x2D7C770 Offset: 0x2D7C871 VA: 0x2D7C770
	|-Func<int, int, int>.Invoke
	|
	|-RVA: 0x2D7CB10 Offset: 0x2D7CC11 VA: 0x2D7CB10
	|-Func<int, IntPtr, bool>.Invoke
	|
	|-RVA: 0x2D7F3E0 Offset: 0x2D7F4E1 VA: 0x2D7F3E0
	|-Func<float, float, bool>.Invoke
	|
	|-RVA: 0x2D7F780 Offset: 0x2D7F881 VA: 0x2D7F780
	|-Func<float, float, float>.Invoke
	|
	|-RVA: 0x2D7D800 Offset: 0x2D7D901 VA: 0x2D7D800
	|-Func<LogType, object, bool>.Invoke
	|-Func<Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x2D7E130 Offset: 0x2D7E231 VA: 0x2D7E130
	|-Func<object, object, bool>.Invoke
	|
	|-RVA: 0x2D7E5E0 Offset: 0x2D7E6E1 VA: 0x2D7E5E0
	|-Func<object, object, int>.Invoke
	|
	|-RVA: 0x2D7EA90 Offset: 0x2D7EB91 VA: 0x2D7EA90
	|-Func<object, object, object>.Invoke
	|
	|-RVA: 0x2D7EF20 Offset: 0x2D7F021 VA: 0x2D7EF20
	|-Func<object, object, VoidTaskResult>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7C680 Offset: 0x2D7C781 VA: 0x2D7C680
	|-Func<int, int, bool>.BeginInvoke
	|
	|-RVA: 0x2D7CA20 Offset: 0x2D7CB21 VA: 0x2D7CA20
	|-Func<int, int, int>.BeginInvoke
	|
	|-RVA: 0x2D7CDD0 Offset: 0x2D7CED1 VA: 0x2D7CDD0
	|-Func<int, IntPtr, bool>.BeginInvoke
	|
	|-RVA: 0x2D7D180 Offset: 0x2D7D281 VA: 0x2D7D180
	|-Func<int, object, object>.BeginInvoke
	|
	|-RVA: 0x2D7D700 Offset: 0x2D7D801 VA: 0x2D7D700
	|-Func<Int32Enum, DamageResult, bool>.BeginInvoke
	|
	|-RVA: 0x2D7DAE0 Offset: 0x2D7DBE1 VA: 0x2D7DAE0
	|-Func<Int32Enum, object, bool>.BeginInvoke
	|
	|-RVA: 0x2D7E040 Offset: 0x2D7E141 VA: 0x2D7E040
	|-Func<object, int, int>.BeginInvoke
	|
	|-RVA: 0x2D7E560 Offset: 0x2D7E661 VA: 0x2D7E560
	|-Func<object, object, bool>.BeginInvoke
	|
	|-RVA: 0x2D7EA10 Offset: 0x2D7EB11 VA: 0x2D7EA10
	|-Func<object, object, int>.BeginInvoke
	|
	|-RVA: 0x2D7EEC0 Offset: 0x2D7EFC1 VA: 0x2D7EEC0
	|-Func<object, object, object>.BeginInvoke
	|
	|-RVA: 0x2D7F360 Offset: 0x2D7F461 VA: 0x2D7F360
	|-Func<object, object, VoidTaskResult>.BeginInvoke
	|
	|-RVA: 0x2D7F690 Offset: 0x2D7F791 VA: 0x2D7F690
	|-Func<float, float, bool>.BeginInvoke
	|
	|-RVA: 0x2D7FA30 Offset: 0x2D7FB31 VA: 0x2D7FA30
	|-Func<float, float, float>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7C720 Offset: 0x2D7C821 VA: 0x2D7C720
	|-Func<int, int, bool>.EndInvoke
	|
	|-RVA: 0x2D7CAC0 Offset: 0x2D7CBC1 VA: 0x2D7CAC0
	|-Func<int, int, int>.EndInvoke
	|
	|-RVA: 0x2D7CE80 Offset: 0x2D7CF81 VA: 0x2D7CE80
	|-Func<int, IntPtr, bool>.EndInvoke
	|
	|-RVA: 0x2D7D220 Offset: 0x2D7D321 VA: 0x2D7D220
	|-Func<int, object, object>.EndInvoke
	|
	|-RVA: 0x2D7D7B0 Offset: 0x2D7D8B1 VA: 0x2D7D7B0
	|-Func<Int32Enum, DamageResult, bool>.EndInvoke
	|
	|-RVA: 0x2D7DB80 Offset: 0x2D7DC81 VA: 0x2D7DB80
	|-Func<Int32Enum, object, bool>.EndInvoke
	|
	|-RVA: 0x2D7E0E0 Offset: 0x2D7E1E1 VA: 0x2D7E0E0
	|-Func<object, int, int>.EndInvoke
	|
	|-RVA: 0x2D7E590 Offset: 0x2D7E691 VA: 0x2D7E590
	|-Func<object, object, bool>.EndInvoke
	|
	|-RVA: 0x2D7EA40 Offset: 0x2D7EB41 VA: 0x2D7EA40
	|-Func<object, object, int>.EndInvoke
	|
	|-RVA: 0x2D7EEF0 Offset: 0x2D7EFF1 VA: 0x2D7EEF0
	|-Func<object, object, object>.EndInvoke
	|
	|-RVA: 0x2D7F390 Offset: 0x2D7F491 VA: 0x2D7F390
	|-Func<object, object, VoidTaskResult>.EndInvoke
	|
	|-RVA: 0x2D7F730 Offset: 0x2D7F831 VA: 0x2D7F730
	|-Func<float, float, bool>.EndInvoke
	|
	|-RVA: 0x2D7FAD0 Offset: 0x2D7FBD1 VA: 0x2D7FAD0
	|-Func<float, float, float>.EndInvoke
	*/
}

[TypeForwardedFromAttribute] // RVA: 0xAB8A0 Offset: 0xAB9A1 VA: 0xAB8A0
public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate // TypeDefIndex: 160
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7FB00 Offset: 0x2D7FC01 VA: 0x2D7FB00
	|-Func<ReadOnlySequence<byte>, object, CancellationToken, object>..ctor
	|
	|-RVA: 0x2B0E5A0 Offset: 0x2B0E6A1 VA: 0x2B0E5A0
	|-Func<object, object, bool, object>..ctor
	|-Func<Assembly, string, bool, Type>..ctor
	|
	|-RVA: 0x2B0EAD0 Offset: 0x2B0EBD1 VA: 0x2B0EAD0
	|-Func<object, object, object, object>..ctor
	|
	|-RVA: 0x2B0EF80 Offset: 0x2B0F081 VA: 0x2B0EF80
	|-Func<object, object, CancellationToken, object>..ctor
	|
	|-RVA: 0x2B0F4A0 Offset: 0x2B0F5A1 VA: 0x2B0F4A0
	|-Func<object, object, CancellationToken, ValueTask<object>>..ctor
	|
	|-RVA: 0x2B0F9F0 Offset: 0x2B0FAF1 VA: 0x2B0F9F0
	|-Func<ReadOnlyMemory<byte>, object, CancellationToken, object>..ctor
	|
	|-RVA: 0x2B0FE00 Offset: 0x2B0FF01 VA: 0x2B0FE00
	|-Func<float, float, float, float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7FB20 Offset: 0x2D7FC21 VA: 0x2D7FB20
	|-Func<ReadOnlySequence<byte>, MessagePackSerializerOptions, CancellationToken, object>.Invoke
	|-Func<ReadOnlySequence<byte>, object, CancellationToken, object>.Invoke
	|
	|-RVA: 0x2B0EFA0 Offset: 0x2B0F0A1 VA: 0x2B0EFA0
	|-Func<Stream, MessagePackSerializerOptions, CancellationToken, object>.Invoke
	|-Func<object, MessagePackSerializerOptions, CancellationToken, byte[]>.Invoke
	|-Func<object, object, CancellationToken, object>.Invoke
	|
	|-RVA: 0x2B0F4C0 Offset: 0x2B0F5C1 VA: 0x2B0F4C0
	|-Func<Stream, MessagePackSerializerOptions, CancellationToken, ValueTask<object>>.Invoke
	|-Func<object, object, CancellationToken, ValueTask<object>>.Invoke
	|
	|-RVA: 0x2B0FA10 Offset: 0x2B0FB11 VA: 0x2B0FA10
	|-Func<ReadOnlyMemory<byte>, MessagePackSerializerOptions, CancellationToken, object>.Invoke
	|-Func<ReadOnlyMemory<byte>, object, CancellationToken, object>.Invoke
	|
	|-RVA: 0x2B0FE20 Offset: 0x2B0FF21 VA: 0x2B0FE20
	|-Func<float, float, float, float>.Invoke
	|
	|-RVA: 0x2B0E5C0 Offset: 0x2B0E6C1 VA: 0x2B0E5C0
	|-Func<object, object, bool, object>.Invoke
	|-Func<Assembly, string, bool, Type>.Invoke
	|
	|-RVA: 0x2B0EAF0 Offset: 0x2B0EBF1 VA: 0x2B0EAF0
	|-Func<object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7FEE0 Offset: 0x2D7FFE1 VA: 0x2D7FEE0
	|-Func<ReadOnlySequence<byte>, object, CancellationToken, object>.BeginInvoke
	|
	|-RVA: 0x2B0EA10 Offset: 0x2B0EB11 VA: 0x2B0EA10
	|-Func<object, object, bool, object>.BeginInvoke
	|
	|-RVA: 0x2B0EF40 Offset: 0x2B0F041 VA: 0x2B0EF40
	|-Func<object, object, object, object>.BeginInvoke
	|
	|-RVA: 0x2B0F3F0 Offset: 0x2B0F4F1 VA: 0x2B0F3F0
	|-Func<object, object, CancellationToken, object>.BeginInvoke
	|
	|-RVA: 0x2B0F900 Offset: 0x2B0FA01 VA: 0x2B0F900
	|-Func<object, object, CancellationToken, ValueTask<object>>.BeginInvoke
	|
	|-RVA: 0x2B0FD30 Offset: 0x2B0FE31 VA: 0x2B0FD30
	|-Func<ReadOnlyMemory<byte>, object, CancellationToken, object>.BeginInvoke
	|
	|-RVA: 0x2B100F0 Offset: 0x2B101F1 VA: 0x2B100F0
	|-Func<float, float, float, float>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D7FFA0 Offset: 0x2D800A1 VA: 0x2D7FFA0
	|-Func<ReadOnlySequence<byte>, object, CancellationToken, object>.EndInvoke
	|
	|-RVA: 0x2B0EAC0 Offset: 0x2B0EBC1 VA: 0x2B0EAC0
	|-Func<object, object, bool, object>.EndInvoke
	|
	|-RVA: 0x2B0EF70 Offset: 0x2B0F071 VA: 0x2B0EF70
	|-Func<object, object, object, object>.EndInvoke
	|
	|-RVA: 0x2B0F490 Offset: 0x2B0F591 VA: 0x2B0F490
	|-Func<object, object, CancellationToken, object>.EndInvoke
	|
	|-RVA: 0x2B0F9A0 Offset: 0x2B0FAA1 VA: 0x2B0F9A0
	|-Func<object, object, CancellationToken, ValueTask<object>>.EndInvoke
	|
	|-RVA: 0x2B0FDF0 Offset: 0x2B0FEF1 VA: 0x2B0FDF0
	|-Func<ReadOnlyMemory<byte>, object, CancellationToken, object>.EndInvoke
	|
	|-RVA: 0x2B101A0 Offset: 0x2B102A1 VA: 0x2B101A0
	|-Func<float, float, float, float>.EndInvoke
	*/
}

[TypeForwardedFromAttribute] // RVA: 0xAB8E0 Offset: 0xAB9E1 VA: 0xAB8E0
public sealed class Func<T1, T2, T3, T4, TResult> : MulticastDelegate // TypeDefIndex: 161
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B10CF0 Offset: 0x2B10DF1 VA: 0x2B10CF0
	|-Func<Behavior, GameObject, string, Transform, BehaviorManager.BehaviorTree>..ctor
	|-Func<object, object, object, object, object>..ctor
	|
	|-RVA: 0x2B101D0 Offset: 0x2B102D1 VA: 0x2B101D0
	|-Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult>..ctor
	|-Func<object, Stream.ReadWriteParameters, object, object, object>..ctor
	|
	|-RVA: 0x2B10790 Offset: 0x2B10891 VA: 0x2B10790
	|-Func<object, object, bool, object, object>..ctor
	|
	|-RVA: 0x2B111E0 Offset: 0x2B112E1 VA: 0x2B111E0
	|-Func<object, object, object, CancellationToken, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B10D10 Offset: 0x2B10E11 VA: 0x2B10D10
	|-Func<Behavior, GameObject, string, Transform, BehaviorManager.BehaviorTree>.Invoke
	|-Func<object, object, object, object, object>.Invoke
	|
	|-RVA: 0x2B11200 Offset: 0x2B11301 VA: 0x2B11200
	|-Func<Stream, object, MessagePackSerializerOptions, CancellationToken, Task>.Invoke
	|-Func<object, object, object, CancellationToken, object>.Invoke
	|
	|-RVA: 0x2B107B0 Offset: 0x2B108B1 VA: 0x2B107B0
	|-Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>.Invoke
	|-Func<object, object, bool, object, object>.Invoke
	|
	|-RVA: 0x2B101F0 Offset: 0x2B102F1 VA: 0x2B101F0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B106D0 Offset: 0x2B107D1 VA: 0x2B106D0
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.BeginInvoke
	|
	|-RVA: 0x2B10C30 Offset: 0x2B10D31 VA: 0x2B10C30
	|-Func<object, object, bool, object, object>.BeginInvoke
	|
	|-RVA: 0x2B11190 Offset: 0x2B11291 VA: 0x2B11190
	|-Func<object, object, object, object, object>.BeginInvoke
	|
	|-RVA: 0x2B11680 Offset: 0x2B11781 VA: 0x2B11680
	|-Func<object, object, object, CancellationToken, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B10780 Offset: 0x2B10881 VA: 0x2B10780
	|-Func<object, Stream.ReadWriteParameters, object, object, object>.EndInvoke
	|
	|-RVA: 0x2B10CE0 Offset: 0x2B10DE1 VA: 0x2B10CE0
	|-Func<object, object, bool, object, object>.EndInvoke
	|
	|-RVA: 0x2B111D0 Offset: 0x2B112D1 VA: 0x2B111D0
	|-Func<object, object, object, object, object>.EndInvoke
	|
	|-RVA: 0x2B11730 Offset: 0x2B11831 VA: 0x2B11730
	|-Func<object, object, object, CancellationToken, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, TResult> : MulticastDelegate // TypeDefIndex: 166
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11740 Offset: 0x2B11841 VA: 0x2B11740
	|-Func<object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11760 Offset: 0x2B11861 VA: 0x2B11760
	|-Func<object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11C10 Offset: 0x2B11D11 VA: 0x2B11C10
	|-Func<object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11C50 Offset: 0x2B11D51 VA: 0x2B11C50
	|-Func<object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, TResult> : MulticastDelegate // TypeDefIndex: 167
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11C60 Offset: 0x2B11D61 VA: 0x2B11C60
	|-Func<object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B11C80 Offset: 0x2B11D81 VA: 0x2B11C80
	|-Func<object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12130 Offset: 0x2B12231 VA: 0x2B12130
	|-Func<object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12170 Offset: 0x2B12271 VA: 0x2B12170
	|-Func<object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, TResult> : MulticastDelegate // TypeDefIndex: 168
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12180 Offset: 0x2B12281 VA: 0x2B12180
	|-Func<object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B121A0 Offset: 0x2B122A1 VA: 0x2B121A0
	|-Func<object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12670 Offset: 0x2B12771 VA: 0x2B12670
	|-Func<object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B126B0 Offset: 0x2B127B1 VA: 0x2B126B0
	|-Func<object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : MulticastDelegate // TypeDefIndex: 169
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B126C0 Offset: 0x2B127C1 VA: 0x2B126C0
	|-Func<object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B126E0 Offset: 0x2B127E1 VA: 0x2B126E0
	|-Func<object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12BB0 Offset: 0x2B12CB1 VA: 0x2B12BB0
	|-Func<object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B12BF0 Offset: 0x2B12CF1 VA: 0x2B12BF0
	|-Func<object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : MulticastDelegate // TypeDefIndex: 2151
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F060 Offset: 0x2D5F161 VA: 0x2D5F060
	|-Func<object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F080 Offset: 0x2D5F181 VA: 0x2D5F080
	|-Func<object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F560 Offset: 0x2D5F661 VA: 0x2D5F560
	|-Func<object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F5A0 Offset: 0x2D5F6A1 VA: 0x2D5F5A0
	|-Func<object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : MulticastDelegate // TypeDefIndex: 2152
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F5B0 Offset: 0x2D5F6B1 VA: 0x2D5F5B0
	|-Func<object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5F5D0 Offset: 0x2D5F6D1 VA: 0x2D5F5D0
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5FAA0 Offset: 0x2D5FBA1 VA: 0x2D5FAA0
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5FAF0 Offset: 0x2D5FBF1 VA: 0x2D5FAF0
	|-Func<object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : MulticastDelegate // TypeDefIndex: 2153
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5FB00 Offset: 0x2D5FC01 VA: 0x2D5FB00
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5FB20 Offset: 0x2D5FC21 VA: 0x2D5FB20
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D5FFF0 Offset: 0x2D600F1 VA: 0x2D5FFF0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60040 Offset: 0x2D60141 VA: 0x2D60040
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : MulticastDelegate // TypeDefIndex: 2154
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60050 Offset: 0x2D60151 VA: 0x2D60050
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60070 Offset: 0x2D60171 VA: 0x2D60070
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60540 Offset: 0x2D60641 VA: 0x2D60540
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60590 Offset: 0x2D60691 VA: 0x2D60590
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : MulticastDelegate // TypeDefIndex: 2155
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D605A0 Offset: 0x2D606A1 VA: 0x2D605A0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D605C0 Offset: 0x2D606C1 VA: 0x2D605C0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60AD0 Offset: 0x2D60BD1 VA: 0x2D60AD0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60B30 Offset: 0x2D60C31 VA: 0x2D60B30
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : MulticastDelegate // TypeDefIndex: 2156
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60B40 Offset: 0x2D60C41 VA: 0x2D60B40
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D60B60 Offset: 0x2D60C61 VA: 0x2D60B60
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D610B0 Offset: 0x2D611B1 VA: 0x2D610B0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61110 Offset: 0x2D61211 VA: 0x2D61110
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : MulticastDelegate // TypeDefIndex: 2157
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61120 Offset: 0x2D61221 VA: 0x2D61120
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61140 Offset: 0x2D61241 VA: 0x2D61140
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D616D0 Offset: 0x2D617D1 VA: 0x2D616D0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61730 Offset: 0x2D61831 VA: 0x2D61730
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : MulticastDelegate // TypeDefIndex: 2158
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61740 Offset: 0x2D61841 VA: 0x2D61740
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61760 Offset: 0x2D61861 VA: 0x2D61760
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61D40 Offset: 0x2D61E41 VA: 0x2D61D40
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D61DA0 Offset: 0x2D61EA1 VA: 0x2D61DA0
	|-Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>.EndInvoke
	*/
}

