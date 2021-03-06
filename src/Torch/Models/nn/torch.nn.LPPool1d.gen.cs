// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Applies a 1D power-average pooling over an input signal composed of several input
            ///	planes.<br></br>
            ///	
            ///	On each window, the function computed is:
            ///	
            ///	\[f(X) = \sqrt[p]{\sum_{x \in X} x^{p}}
            ///	
            ///	\]
            ///	
            ///	At p = \(\infty\), one gets Max Pooling
            ///	At p = 1, one gets Sum Pooling (which is proportional to Average Pooling)
            ///	
            ///	Note
            ///	If the sum to the power of p is zero, the gradient of this function is
            ///	not defined.<br></br>
            ///	 This implementation will set the gradient to zero in this case.
            /// </summary>
            public partial class LPPool1d : Module
            {
                // auto-generated class
                
                public LPPool1d(PyObject pyobj) : base(pyobj) { }
                
                public LPPool1d(Module other) : base(other.PyObject as PyObject) { }
                
                public LPPool1d(int kernel_size, int stride = 1, bool ceil_mode = false)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        kernel_size,
                    });
                    var kwargs=new PyDict();
                    if (stride!=1) kwargs["stride"]=ToPython(stride);
                    if (ceil_mode!=false) kwargs["ceil_mode"]=ToPython(ceil_mode);
                    dynamic py = __self__.InvokeMethod("LPPool1d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
