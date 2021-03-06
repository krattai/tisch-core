/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class StateRegion : Region {
  private HandleRef swigCPtr;

  internal StateRegion(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.StateRegionUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StateRegion obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StateRegion() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_StateRegion(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StateRegion(ulong _id) : this(libtischPINVOKE.new_StateRegion__SWIG_0(_id), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public StateRegion() : this(libtischPINVOKE.new_StateRegion__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public StateRegion assign(Region reg) {
    StateRegion ret = new StateRegion(libtischPINVOKE.StateRegion_assign(swigCPtr, Region.getCPtr(reg)), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void update() {
    libtischPINVOKE.StateRegion_update(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gesture nextMatch() {
    IntPtr cPtr = libtischPINVOKE.StateRegion_nextMatch(swigCPtr);
    Gesture ret = (cPtr == IntPtr.Zero) ? null : new Gesture(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ulong id {
    set {
      libtischPINVOKE.StateRegion_id_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ulong ret = libtischPINVOKE.StateRegion_id_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int first {
    set {
      libtischPINVOKE.StateRegion_first_set(swigCPtr, value);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = libtischPINVOKE.StateRegion_first_get(swigCPtr);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public InputState state {
    set {
      libtischPINVOKE.StateRegion_state_set(swigCPtr, InputState.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.StateRegion_state_get(swigCPtr);
      InputState ret = (cPtr == IntPtr.Zero) ? null : new InputState(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_Gesture_t__iterator gst {
    set {
      libtischPINVOKE.StateRegion_gst_set(swigCPtr, SWIGTYPE_p_std__vectorT_Gesture_t__iterator.getCPtr(value));
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = libtischPINVOKE.StateRegion_gst_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_Gesture_t__iterator ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_Gesture_t__iterator(cPtr, false);
      if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
