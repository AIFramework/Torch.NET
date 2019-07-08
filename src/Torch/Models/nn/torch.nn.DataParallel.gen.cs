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
            ///	Implements data parallelism at the module level.<br></br>
            ///	
            ///	This container parallelizes the application of the given module by
            ///	splitting the input across the specified devices by chunking in the batch
            ///	dimension (other objects will be copied once per device).<br></br>
            ///	 In the forward
            ///	pass, the module is replicated on each device, and each replica handles a
            ///	portion of the input.<br></br>
            ///	 During the backwards pass, gradients from each replica
            ///	are summed into the original module.<br></br>
            ///	
            ///	The batch size should be larger than the number of GPUs used.<br></br>
            ///	
            ///	See also: Use nn.DataParallel instead of multiprocessing
            ///	
            ///	Arbitrary positional and keyword inputs are allowed to be passed into
            ///	DataParallel but some types are specially handled.<br></br>
            ///	 tensors will be
            ///	scattered on dim specified (default 0).<br></br>
            ///	 tuple, list and dict types will
            ///	be shallow copied.<br></br>
            ///	 The other types will be shared among different threads
            ///	and can be corrupted if written to in the model’s forward pass.<br></br>
            ///	
            ///	The parallelized module must have its parameters and buffers on
            ///	device_ids[0] before running this DataParallel
            ///	module.<br></br>
            ///	
            ///	Warning
            ///	In each forward, module is replicated on each device, so any
            ///	updates to the running module in forward will be lost.<br></br>
            ///	 For example,
            ///	if module has a counter attribute that is incremented in each
            ///	forward, it will always stay at the initial value because the update
            ///	is done on the replicas which are destroyed after forward.<br></br>
            ///	 However,
            ///	DataParallel guarantees that the replica on
            ///	device[0] will have its parameters and buffers sharing storage with
            ///	the base parallelized module.<br></br>
            ///	 So in-place updates to the
            ///	parameters or buffers on device[0] will be recorded.<br></br>
            ///	 E.g.,
            ///	BatchNorm2d and spectral_norm()
            ///	rely on this behavior to update the buffers.<br></br>
            ///	
            ///	Warning
            ///	Forward and backward hooks defined on module and its submodules
            ///	will be invoked len(device_ids) times, each with inputs located on
            ///	a particular device.<br></br>
            ///	 Particularly, the hooks are only guaranteed to be
            ///	executed in correct order with respect to operations on corresponding
            ///	devices.<br></br>
            ///	 For example, it is not guaranteed that hooks set via
            ///	register_forward_pre_hook() be executed before
            ///	all len(device_ids) forward() calls, but
            ///	that each such hook be executed before the corresponding
            ///	forward() call of that device.<br></br>
            ///	
            ///	Warning
            ///	When module returns a scalar (i.e., 0-dimensional tensor) in
            ///	forward(), this wrapper will return a vector of length equal to
            ///	number of devices used in data parallelism, containing the result from
            ///	each device.<br></br>
            ///	
            ///	Note
            ///	There is a subtlety in using the
            ///	pack sequence -&gt; recurrent network -&gt; unpack sequence pattern in a
            ///	Module wrapped in DataParallel.<br></br>
            ///	
            ///	See My recurrent network doesn’t work with data parallelism section in FAQ for
            ///	details.
            /// </summary>
            public partial class DataParallel : Module
            {
                // auto-generated class
                
                public DataParallel(PyObject pyobj) : base(pyobj) { }
                
                public DataParallel(Module other) : base(other.PyObject as PyObject) { }
                
                public DataParallel(Module module, int[] device_ids, int? output_device = null)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        module,
                        device_ids,
                    });
                    var kwargs=new PyDict();
                    if (output_device!=null) kwargs["output_device"]=ToPython(output_device);
                    dynamic py = __self__.InvokeMethod("DataParallel", pyargs, kwargs);
                    self=py as PyObject;
                }
                public DataParallel(Module module, Device[] device_ids, Device output_device = null)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        module,
                    });
                    var kwargs=new PyDict();
                    if (device_ids!=null) kwargs["device_ids"]=ToPython(device_ids);
                    if (output_device!=null) kwargs["output_device"]=ToPython(output_device);
                    dynamic py = __self__.InvokeMethod("DataParallel", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}