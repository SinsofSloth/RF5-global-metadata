[ExtensionAttribute] // RVA: 0x137550 Offset: 0x137651 VA: 0x137550
public static class TweenExtensions // TypeDefIndex: 4931
{
	// Methods

	[ExtensionAttribute] // RVA: 0x137C70 Offset: 0x137D71 VA: 0x137C70
	// RVA: 0x1B91320 Offset: 0x1B91421 VA: 0x1B91320
	public static void Complete(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137C80 Offset: 0x137D81 VA: 0x137C80
	// RVA: 0x1B91330 Offset: 0x1B91431 VA: 0x1B91330
	public static void Complete(Tween t, bool withCallbacks) { }

	[ExtensionAttribute] // RVA: 0x137C90 Offset: 0x137D91 VA: 0x137C90
	// RVA: 0x1B91530 Offset: 0x1B91631 VA: 0x1B91530
	public static void Flip(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137CA0 Offset: 0x137DA1 VA: 0x137CA0
	// RVA: 0x1B916C0 Offset: 0x1B917C1 VA: 0x1B916C0
	public static void ForceInit(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137CB0 Offset: 0x137DB1 VA: 0x137CB0
	// RVA: 0x1B90710 Offset: 0x1B90811 VA: 0x1B90710
	public static void Goto(Tween t, float to, bool andPlay = False) { }

	[ExtensionAttribute] // RVA: 0x137CC0 Offset: 0x137DC1 VA: 0x137CC0
	// RVA: 0x1B91860 Offset: 0x1B91961 VA: 0x1B91860
	public static void Kill(Tween t, bool complete = False) { }

	[ExtensionAttribute] // RVA: 0x137CD0 Offset: 0x137DD1 VA: 0x137CD0
	// RVA: -1 Offset: -1
	public static T Pause<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BF2F0 Offset: 0x23BF3F1 VA: 0x23BF2F0
	|-TweenExtensions.Pause<TweenerCore<Vector3, Vector3, VectorOptions>>
	|-TweenExtensions.Pause<Sequence>
	|-TweenExtensions.Pause<object>
	*/

	[ExtensionAttribute] // RVA: 0x137CE0 Offset: 0x137DE1 VA: 0x137CE0
	// RVA: -1 Offset: -1
	public static T Play<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BF4A0 Offset: 0x23BF5A1 VA: 0x23BF4A0
	|-TweenExtensions.Play<Sequence>
	|-TweenExtensions.Play<object>
	*/

	[ExtensionAttribute] // RVA: 0x137CF0 Offset: 0x137DF1 VA: 0x137CF0
	// RVA: 0x1B91AC0 Offset: 0x1B91BC1 VA: 0x1B91AC0
	public static void PlayBackwards(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D00 Offset: 0x137E01 VA: 0x137D00
	// RVA: 0x1B91C50 Offset: 0x1B91D51 VA: 0x1B91C50
	public static void PlayForward(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D10 Offset: 0x137E11 VA: 0x137D10
	// RVA: 0x1B91DE0 Offset: 0x1B91EE1 VA: 0x1B91DE0
	public static void Restart(Tween t, bool includeDelay = True, float changeDelayTo = -1) { }

	[ExtensionAttribute] // RVA: 0x137D20 Offset: 0x137E21 VA: 0x137D20
	// RVA: 0x1B91FB0 Offset: 0x1B920B1 VA: 0x1B91FB0
	public static void Rewind(Tween t, bool includeDelay = True) { }

	[ExtensionAttribute] // RVA: 0x137D30 Offset: 0x137E31 VA: 0x137D30
	// RVA: 0x1B92160 Offset: 0x1B92261 VA: 0x1B92160
	public static void SmoothRewind(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D40 Offset: 0x137E41 VA: 0x137D40
	// RVA: 0x1B922F0 Offset: 0x1B923F1 VA: 0x1B922F0
	public static void TogglePause(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D50 Offset: 0x137E51 VA: 0x137D50
	// RVA: 0x1B92480 Offset: 0x1B92581 VA: 0x1B92480
	public static void GotoWaypoint(Tween t, int waypointIndex, bool andPlay = False) { }

	[ExtensionAttribute] // RVA: 0x137D60 Offset: 0x137E61 VA: 0x137D60
	// RVA: 0x1B92820 Offset: 0x1B92921 VA: 0x1B92820
	public static YieldInstruction WaitForCompletion(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D70 Offset: 0x137E71 VA: 0x137D70
	// RVA: 0x1B92930 Offset: 0x1B92A31 VA: 0x1B92930
	public static YieldInstruction WaitForRewind(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D80 Offset: 0x137E81 VA: 0x137D80
	// RVA: 0x1B92A40 Offset: 0x1B92B41 VA: 0x1B92A40
	public static YieldInstruction WaitForKill(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137D90 Offset: 0x137E91 VA: 0x137D90
	// RVA: 0x1B92B50 Offset: 0x1B92C51 VA: 0x1B92B50
	public static YieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[ExtensionAttribute] // RVA: 0x137DA0 Offset: 0x137EA1 VA: 0x137DA0
	// RVA: 0x1B92C80 Offset: 0x1B92D81 VA: 0x1B92C80
	public static YieldInstruction WaitForPosition(Tween t, float position) { }

	[ExtensionAttribute] // RVA: 0x137DB0 Offset: 0x137EB1 VA: 0x137DB0
	// RVA: 0x1B92DB0 Offset: 0x1B92EB1 VA: 0x1B92DB0
	public static Coroutine WaitForStart(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137DC0 Offset: 0x137EC1 VA: 0x137DC0
	// RVA: 0x1B92EB0 Offset: 0x1B92FB1 VA: 0x1B92EB0
	public static int CompletedLoops(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137DD0 Offset: 0x137ED1 VA: 0x137DD0
	// RVA: 0x1B92F50 Offset: 0x1B93051 VA: 0x1B92F50
	public static float Delay(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137DE0 Offset: 0x137EE1 VA: 0x137DE0
	// RVA: 0x1B92FF0 Offset: 0x1B930F1 VA: 0x1B92FF0
	public static float Duration(Tween t, bool includeLoops = True) { }

	[ExtensionAttribute] // RVA: 0x137DF0 Offset: 0x137EF1 VA: 0x137DF0
	// RVA: 0x1B90640 Offset: 0x1B90741 VA: 0x1B90640
	public static float Elapsed(Tween t, bool includeLoops = True) { }

	[ExtensionAttribute] // RVA: 0x137E00 Offset: 0x137F01 VA: 0x137E00
	// RVA: 0x1B930B0 Offset: 0x1B931B1 VA: 0x1B930B0
	public static float ElapsedPercentage(Tween t, bool includeLoops = True) { }

	[ExtensionAttribute] // RVA: 0x137E10 Offset: 0x137F11 VA: 0x137E10
	// RVA: 0x1B93190 Offset: 0x1B93291 VA: 0x1B93190
	public static float ElapsedDirectionalPercentage(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E20 Offset: 0x137F21 VA: 0x137E20
	// RVA: 0x1B93260 Offset: 0x1B93361 VA: 0x1B93260
	public static bool IsActive(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E30 Offset: 0x137F31 VA: 0x137E30
	// RVA: 0x1B93280 Offset: 0x1B93381 VA: 0x1B93280
	public static bool IsBackwards(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E40 Offset: 0x137F41 VA: 0x137E40
	// RVA: 0x1B93330 Offset: 0x1B93431 VA: 0x1B93330
	public static bool IsComplete(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E50 Offset: 0x137F51 VA: 0x137E50
	// RVA: 0x1B933E0 Offset: 0x1B934E1 VA: 0x1B933E0
	public static bool IsInitialized(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E60 Offset: 0x137F61 VA: 0x137E60
	// RVA: 0x1B93490 Offset: 0x1B93591 VA: 0x1B93490
	public static bool IsPlaying(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E70 Offset: 0x137F71 VA: 0x137E70
	// RVA: 0x1B93540 Offset: 0x1B93641 VA: 0x1B93540
	public static int Loops(Tween t) { }

	[ExtensionAttribute] // RVA: 0x137E80 Offset: 0x137F81 VA: 0x137E80
	// RVA: 0x1B935E0 Offset: 0x1B936E1 VA: 0x1B935E0
	public static Vector3 PathGetPoint(Tween t, float pathPercentage) { }

	[ExtensionAttribute] // RVA: 0x137E90 Offset: 0x137F91 VA: 0x137E90
	// RVA: 0x1B93890 Offset: 0x1B93991 VA: 0x1B93890
	public static Vector3[] PathGetDrawPoints(Tween t, int subdivisionsXSegment = 10) { }

	[ExtensionAttribute] // RVA: 0x137EA0 Offset: 0x137FA1 VA: 0x137EA0
	// RVA: 0x1B93B00 Offset: 0x1B93C01 VA: 0x1B93B00
	public static float PathLength(Tween t) { }
}

