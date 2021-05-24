public sealed class Sequence : Tween // TypeDefIndex: 4933
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
	internal float lastTweenInsertTime; // 0x130

	// Methods

	// RVA: 0x19EFB10 Offset: 0x19EFC11 VA: 0x19EFB10
	internal void .ctor() { }

	// RVA: 0x19EFBE0 Offset: 0x19EFCE1 VA: 0x19EFBE0
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x19EFCF0 Offset: 0x19EFDF1 VA: 0x19EFCF0
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x19EFE30 Offset: 0x19EFF31 VA: 0x19EFE30
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFF30 Offset: 0x19F0031 VA: 0x19EFF30
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x19EFFF0 Offset: 0x19F00F1 VA: 0x19EFFF0 Slot: 4
	internal override void Reset() { }

	// RVA: 0x19F0080 Offset: 0x19F0181 VA: 0x19F0080 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x19F0150 Offset: 0x19F0251 VA: 0x19F0150 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x19F02E0 Offset: 0x19F03E1 VA: 0x19F02E0 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x19F0600 Offset: 0x19F0701 VA: 0x19F0600
	internal static void Setup(Sequence s) { }

	// RVA: 0x19F0160 Offset: 0x19F0261 VA: 0x19F0160
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x19F02F0 Offset: 0x19F03F1 VA: 0x19F02F0
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x19F0960 Offset: 0x19F0A61 VA: 0x19F0960
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x19F07B0 Offset: 0x19F08B1 VA: 0x19F07B0
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	// RVA: 0x19F0720 Offset: 0x19F0821 VA: 0x19F0720
	private static bool IsAnyCallbackSet(Sequence s) { }
}

public sealed class Sequence : Tween // TypeDefIndex: 4933
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
	internal float lastTweenInsertTime; // 0x130

	// Methods

	// RVA: 0x19EFB10 Offset: 0x19EFC11 VA: 0x19EFB10
	internal void .ctor() { }

	// RVA: 0x19EFBE0 Offset: 0x19EFCE1 VA: 0x19EFBE0
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x19EFCF0 Offset: 0x19EFDF1 VA: 0x19EFCF0
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x19EFE30 Offset: 0x19EFF31 VA: 0x19EFE30
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFF30 Offset: 0x19F0031 VA: 0x19EFF30
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x19EFFF0 Offset: 0x19F00F1 VA: 0x19EFFF0 Slot: 4
	internal override void Reset() { }

	// RVA: 0x19F0080 Offset: 0x19F0181 VA: 0x19F0080 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x19F0150 Offset: 0x19F0251 VA: 0x19F0150 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x19F02E0 Offset: 0x19F03E1 VA: 0x19F02E0 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x19F0600 Offset: 0x19F0701 VA: 0x19F0600
	internal static void Setup(Sequence s) { }

	// RVA: 0x19F0160 Offset: 0x19F0261 VA: 0x19F0160
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x19F02F0 Offset: 0x19F03F1 VA: 0x19F02F0
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x19F0960 Offset: 0x19F0A61 VA: 0x19F0960
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x19F07B0 Offset: 0x19F08B1 VA: 0x19F07B0
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	// RVA: 0x19F0720 Offset: 0x19F0821 VA: 0x19F0720
	private static bool IsAnyCallbackSet(Sequence s) { }
}

public sealed class Sequence : Tween // TypeDefIndex: 4933
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
	internal float lastTweenInsertTime; // 0x130

	// Methods

	// RVA: 0x19EFB10 Offset: 0x19EFC11 VA: 0x19EFB10
	internal void .ctor() { }

	// RVA: 0x19EFBE0 Offset: 0x19EFCE1 VA: 0x19EFBE0
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x19EFCF0 Offset: 0x19EFDF1 VA: 0x19EFCF0
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x19EFE30 Offset: 0x19EFF31 VA: 0x19EFE30
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFF30 Offset: 0x19F0031 VA: 0x19EFF30
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x19EFFF0 Offset: 0x19F00F1 VA: 0x19EFFF0 Slot: 4
	internal override void Reset() { }

	// RVA: 0x19F0080 Offset: 0x19F0181 VA: 0x19F0080 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x19F0150 Offset: 0x19F0251 VA: 0x19F0150 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x19F02E0 Offset: 0x19F03E1 VA: 0x19F02E0 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x19F0600 Offset: 0x19F0701 VA: 0x19F0600
	internal static void Setup(Sequence s) { }

	// RVA: 0x19F0160 Offset: 0x19F0261 VA: 0x19F0160
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x19F02F0 Offset: 0x19F03F1 VA: 0x19F02F0
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x19F0960 Offset: 0x19F0A61 VA: 0x19F0960
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x19F07B0 Offset: 0x19F08B1 VA: 0x19F07B0
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	// RVA: 0x19F0720 Offset: 0x19F0821 VA: 0x19F0720
	private static bool IsAnyCallbackSet(Sequence s) { }
}

public sealed class Sequence : Tween // TypeDefIndex: 4933
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
	internal float lastTweenInsertTime; // 0x130

	// Methods

	// RVA: 0x19EFB10 Offset: 0x19EFC11 VA: 0x19EFB10
	internal void .ctor() { }

	// RVA: 0x19EFBE0 Offset: 0x19EFCE1 VA: 0x19EFBE0
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x19EFCF0 Offset: 0x19EFDF1 VA: 0x19EFCF0
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x19EFE30 Offset: 0x19EFF31 VA: 0x19EFE30
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFF30 Offset: 0x19F0031 VA: 0x19EFF30
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x19EFFF0 Offset: 0x19F00F1 VA: 0x19EFFF0 Slot: 4
	internal override void Reset() { }

	// RVA: 0x19F0080 Offset: 0x19F0181 VA: 0x19F0080 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x19F0150 Offset: 0x19F0251 VA: 0x19F0150 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x19F02E0 Offset: 0x19F03E1 VA: 0x19F02E0 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x19F0600 Offset: 0x19F0701 VA: 0x19F0600
	internal static void Setup(Sequence s) { }

	// RVA: 0x19F0160 Offset: 0x19F0261 VA: 0x19F0160
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x19F02F0 Offset: 0x19F03F1 VA: 0x19F02F0
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x19F0960 Offset: 0x19F0A61 VA: 0x19F0960
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x19F07B0 Offset: 0x19F08B1 VA: 0x19F07B0
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	// RVA: 0x19F0720 Offset: 0x19F0821 VA: 0x19F0720
	private static bool IsAnyCallbackSet(Sequence s) { }
}

public sealed class Sequence : Tween // TypeDefIndex: 4933
{
	// Fields
	internal readonly List<Tween> sequencedTweens; // 0x120
	private readonly List<ABSSequentiable> _sequencedObjs; // 0x128
	internal float lastTweenInsertTime; // 0x130

	// Methods

	// RVA: 0x19EFB10 Offset: 0x19EFC11 VA: 0x19EFB10
	internal void .ctor() { }

	// RVA: 0x19EFBE0 Offset: 0x19EFCE1 VA: 0x19EFBE0
	internal static Sequence DoPrepend(Sequence inSequence, Tween t) { }

	// RVA: 0x19EFCF0 Offset: 0x19EFDF1 VA: 0x19EFCF0
	internal static Sequence DoInsert(Sequence inSequence, Tween t, float atPosition) { }

	// RVA: 0x19EFE30 Offset: 0x19EFF31 VA: 0x19EFE30
	internal static Sequence DoAppendInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFE60 Offset: 0x19EFF61 VA: 0x19EFE60
	internal static Sequence DoPrependInterval(Sequence inSequence, float interval) { }

	// RVA: 0x19EFF30 Offset: 0x19F0031 VA: 0x19EFF30
	internal static Sequence DoInsertCallback(Sequence inSequence, TweenCallback callback, float atPosition) { }

	// RVA: 0x19EFFF0 Offset: 0x19F00F1 VA: 0x19EFFF0 Slot: 4
	internal override void Reset() { }

	// RVA: 0x19F0080 Offset: 0x19F0181 VA: 0x19F0080 Slot: 5
	internal override bool Validate() { }

	// RVA: 0x19F0150 Offset: 0x19F0251 VA: 0x19F0150 Slot: 7
	internal override bool Startup() { }

	// RVA: 0x19F02E0 Offset: 0x19F03E1 VA: 0x19F02E0 Slot: 8
	internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice) { }

	// RVA: 0x19F0600 Offset: 0x19F0701 VA: 0x19F0600
	internal static void Setup(Sequence s) { }

	// RVA: 0x19F0160 Offset: 0x19F0261 VA: 0x19F0160
	internal static bool DoStartup(Sequence s) { }

	// RVA: 0x19F02F0 Offset: 0x19F03F1 VA: 0x19F02F0
	internal static bool DoApplyTween(Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode) { }

	// RVA: 0x19F0960 Offset: 0x19F0A61 VA: 0x19F0960
	private static bool ApplyInternalCycle(Sequence s, float fromPos, float toPos, UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep = False) { }

	// RVA: 0x19F07B0 Offset: 0x19F08B1 VA: 0x19F07B0
	private static void StableSortSequencedObjs(List<ABSSequentiable> list) { }

	// RVA: 0x19F0720 Offset: 0x19F0821 VA: 0x19F0720
	private static bool IsAnyCallbackSet(Sequence s) { }
}

