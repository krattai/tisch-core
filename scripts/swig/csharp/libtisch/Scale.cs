/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Scale : FeatureDouble {
  private HandleRef swigCPtr;

  internal Scale(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.ScaleUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Scale obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Scale() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        libtischPINVOKE.delete_Scale(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Scale(int tf) : this(libtischPINVOKE.new_Scale__SWIG_0(tf), true) {
  }

  public Scale() : this(libtischPINVOKE.new_Scale__SWIG_1(), true) {
  }

  public override void load(InputState state) {
    libtischPINVOKE.Scale_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string name() {
    string ret = libtischPINVOKE.Scale_name(swigCPtr);
    return ret;
  }

}
