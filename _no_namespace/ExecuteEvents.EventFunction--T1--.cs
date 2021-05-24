public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 4076
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C1E20 Offset: 0x28C1F21 VA: 0x28C1E20
	|-ExecuteEvents.EventFunction<object>..ctor
	|-ExecuteEvents.EventFunction<IBeginDragHandler>..ctor
	|-ExecuteEvents.EventFunction<ICancelHandler>..ctor
	|-ExecuteEvents.EventFunction<IDeselectHandler>..ctor
	|-ExecuteEvents.EventFunction<IDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IDropHandler>..ctor
	|-ExecuteEvents.EventFunction<IEndDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IInitializePotentialDragHandler>..ctor
	|-ExecuteEvents.EventFunction<IMoveHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerClickHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerDownHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerEnterHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerExitHandler>..ctor
	|-ExecuteEvents.EventFunction<IPointerUpHandler>..ctor
	|-ExecuteEvents.EventFunction<IScrollHandler>..ctor
	|-ExecuteEvents.EventFunction<ISelectHandler>..ctor
	|-ExecuteEvents.EventFunction<ISubmitHandler>..ctor
	|-ExecuteEvents.EventFunction<IUpdateSelectedHandler>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C1E40 Offset: 0x28C1F41 VA: 0x28C1E40
	|-ExecuteEvents.EventFunction<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C2260 Offset: 0x28C2361 VA: 0x28C2260
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C2290 Offset: 0x28C2391 VA: 0x28C2290
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	*/
}

