using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BreastBodyLocation' extension class.
	/// </summary>
	public class BreastBodyLocationExtension : MemberListExtensionValueBase                                                                    // BuildMemberListExtensionValue.cs:307
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:308
	    QuadrantExtensionItem Quadrant;                                                                                                        // BuildMemberListExtensionValue.cs:383
	    RegionExtensionItem Region;                                                                                                            // BuildMemberListExtensionValue.cs:383
	    ClockDirectionExtensionItem ClockDirection;                                                                                            // BuildMemberListExtensionValue.cs:383
	    DepthExtensionItem Depth;                                                                                                              // BuildMemberListExtensionValue.cs:383
	                                                                                                                                           // BuildMemberListExtensionValue.cs:310
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension() : base("BreastBodyLocation")                                                                      // BuildMemberListExtensionValue.cs:314
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:315
	        this.Quadrant = new QuadrantExtensionItem();                                                                                       // BuildMemberListExtensionValue.cs:386
	        this.Region = new RegionExtensionItem();                                                                                           // BuildMemberListExtensionValue.cs:386
	        this.ClockDirection = new ClockDirectionExtensionItem();                                                                           // BuildMemberListExtensionValue.cs:386
	        this.Depth = new DepthExtensionItem();                                                                                             // BuildMemberListExtensionValue.cs:386
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:317
	                                                                                                                                           // BuildMemberListExtensionValue.cs:318
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:319
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:320
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.Quadrant);                                                                                                          // BuildMemberListExtensionValue.cs:389
	        this.Read(this.Region);                                                                                                            // BuildMemberListExtensionValue.cs:389
	        this.Read(this.ClockDirection);                                                                                                    // BuildMemberListExtensionValue.cs:389
	        this.Read(this.Depth);                                                                                                             // BuildMemberListExtensionValue.cs:389
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:325
	                                                                                                                                           // BuildMemberListExtensionValue.cs:326
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:330
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:331
	        this.Write(this.Quadrant);                                                                                                         // BuildMemberListExtensionValue.cs:392
	        this.Write(this.Region);                                                                                                           // BuildMemberListExtensionValue.cs:392
	        this.Write(this.ClockDirection);                                                                                                   // BuildMemberListExtensionValue.cs:392
	        this.Write(this.Depth);                                                                                                            // BuildMemberListExtensionValue.cs:392
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:333
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:334
	/// <summary>
	/// Class that implements the QuadrantExtensionItem' extension slice class.
	/// </summary>
	public class QuadrantExtensionItem : ISimpleExtensionItem                                                                                  // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice quadrant
	    /// [Fhir Element 'Extension.extension:quadrant]'
	    /// </summary>
	    CodeableConcept quadrant;                                                                                                              // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => this.quadrant;                                                                                         // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.quadrant = value;                                                                       // BuildMemberListExtensionValue.cs:461
	                                                                                                                                           // BuildMemberListExtensionValue.cs:411
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:412
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:413
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:415
	                                                                                                                                           // BuildMemberListExtensionValue.cs:416
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:417
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:418
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:420
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:421
	/// <summary>
	/// Class that implements the RegionExtensionItem' extension slice class.
	/// </summary>
	public class RegionExtensionItem : ISimpleExtensionItem                                                                                    // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice region
	    /// [Fhir Element 'Extension.extension:region]'
	    /// </summary>
	    CodeableConcept region;                                                                                                                // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice region
	    /// </summary>
	    public CodeableConcept Get() => this.region;                                                                                           // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice region
	    /// </summary>
	    public void Set(CodeableConcept value) => this.region = value;                                                                         // BuildMemberListExtensionValue.cs:461
	                                                                                                                                           // BuildMemberListExtensionValue.cs:411
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:412
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:413
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:415
	                                                                                                                                           // BuildMemberListExtensionValue.cs:416
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:417
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:418
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:420
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:421
	/// <summary>
	/// Class that implements the ClockDirectionExtensionItem' extension slice class.
	/// </summary>
	public class ClockDirectionExtensionItem : ISimpleExtensionItem                                                                            // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice clockDirection
	    /// [Fhir Element 'Extension.extension:clockDirection]'
	    /// </summary>
	    CodeableConcept clockDirection;                                                                                                        // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => this.clockDirection;                                                                                   // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.clockDirection = value;                                                                 // BuildMemberListExtensionValue.cs:461
	                                                                                                                                           // BuildMemberListExtensionValue.cs:411
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:412
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:413
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:415
	                                                                                                                                           // BuildMemberListExtensionValue.cs:416
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:417
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:418
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:420
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:421
	/// <summary>
	/// Class that implements the DepthExtensionItem' extension slice class.
	/// </summary>
	public class DepthExtensionItem : ISimpleExtensionItem                                                                                     // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice depth
	    /// [Fhir Element 'Extension.extension:depth]'
	    /// </summary>
	    CodeableConcept depth;                                                                                                                 // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => this.depth;                                                                                            // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.depth = value;                                                                          // BuildMemberListExtensionValue.cs:461
	                                                                                                                                           // BuildMemberListExtensionValue.cs:411
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:412
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:413
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:415
	                                                                                                                                           // BuildMemberListExtensionValue.cs:416
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:417
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:418
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:420
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:421
	//- LocalClassDefs
}
