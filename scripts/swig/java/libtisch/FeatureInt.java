/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.36
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class FeatureInt extends FeatureBase {
  private long swigCPtr;

  protected FeatureInt(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGFeatureIntUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FeatureInt obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      libtischJNI.delete_FeatureInt(swigCPtr);
    }
    swigCPtr = 0;
    super.delete();
  }

  public int result() {
    return libtischJNI.FeatureInt_result(swigCPtr, this);
  }

  public void bounds(vectorInt _bounds) {
    libtischJNI.FeatureInt_bounds(swigCPtr, this, vectorInt.getCPtr(_bounds), _bounds);
  }

  public int next() {
    return libtischJNI.FeatureInt_next(swigCPtr, this);
  }

  public void load(InputState state) {
    libtischJNI.FeatureInt_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public String name() {
    return libtischJNI.FeatureInt_name(swigCPtr, this);
  }

  public void serialize(SWIGTYPE_p_std__ostream s) {
    libtischJNI.FeatureInt_serialize(swigCPtr, this, SWIGTYPE_p_std__ostream.getCPtr(s));
  }

  public void unserialize(SWIGTYPE_p_std__istream s) {
    libtischJNI.FeatureInt_unserialize(swigCPtr, this, SWIGTYPE_p_std__istream.getCPtr(s));
  }

}
