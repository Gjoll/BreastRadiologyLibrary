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
	public class BreastBodyLocationExtension : MemberListExtension                                                                             // BuildMemberListExtensionValue.cs:317
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:318
	    QuadrantExtensionItem Quadrant;                                                                                                        // BuildMemberListExtensionValue.cs:392
	    RegionExtensionItem Region;                                                                                                            // BuildMemberListExtensionValue.cs:392
	    ClockDirectionExtensionItem ClockDirection;                                                                                            // BuildMemberListExtensionValue.cs:392
	    DepthExtensionItem Depth;                                                                                                              // BuildMemberListExtensionValue.cs:392
	                                                                                                                                           // BuildMemberListExtensionValue.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension() : base("BreastBodyLocation")                                                                      // BuildMemberListExtensionValue.cs:324
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:325
	        this.Quadrant = new QuadrantExtensionItem();                                                                                       // BuildMemberListExtensionValue.cs:395
	        this.Region = new RegionExtensionItem();                                                                                           // BuildMemberListExtensionValue.cs:395
	        this.ClockDirection = new ClockDirectionExtensionItem();                                                                           // BuildMemberListExtensionValue.cs:395
	        this.Depth = new DepthExtensionItem();                                                                                             // BuildMemberListExtensionValue.cs:395
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:327
	                                                                                                                                           // BuildMemberListExtensionValue.cs:328
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:329
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.Quadrant);                                                                                                          // BuildMemberListExtensionValue.cs:398
	        this.Read(this.Region);                                                                                                            // BuildMemberListExtensionValue.cs:398
	        this.Read(this.ClockDirection);                                                                                                    // BuildMemberListExtensionValue.cs:398
	        this.Read(this.Depth);                                                                                                             // BuildMemberListExtensionValue.cs:398
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:335
	                                                                                                                                           // BuildMemberListExtensionValue.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:340
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:341
	        this.Write(this.Quadrant);                                                                                                         // BuildMemberListExtensionValue.cs:401
	        this.Write(this.Region);                                                                                                           // BuildMemberListExtensionValue.cs:401
	        this.Write(this.ClockDirection);                                                                                                   // BuildMemberListExtensionValue.cs:401
	        this.Write(this.Depth);                                                                                                            // BuildMemberListExtensionValue.cs:401
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:343
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:344
	/// <summary>
	/// Class that implements the QuadrantExtensionItem' extension slice class.
	/// </summary>
	public class QuadrantExtensionItem : ISimpleExtensionItem                                                                                  // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice quadrant
	    /// [Fhir Element 'Extension.extension:quadrant]'
	    /// </summary>
	    CodeableConcept quadrant;                                                                                                              // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => this.quadrant;                                                                                         // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.quadrant = value;                                                                       // BuildMemberListExtensionValue.cs:474
	                                                                                                                                           // BuildMemberListExtensionValue.cs:424
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:425
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:426
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:428
	                                                                                                                                           // BuildMemberListExtensionValue.cs:429
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:430
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:431
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:433
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:434
	/// <summary>
	/// Class that implements the RegionExtensionItem' extension slice class.
	/// </summary>
	public class RegionExtensionItem : ISimpleExtensionItem                                                                                    // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice region
	    /// [Fhir Element 'Extension.extension:region]'
	    /// </summary>
	    CodeableConcept region;                                                                                                                // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice region
	    /// </summary>
	    public CodeableConcept Get() => this.region;                                                                                           // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice region
	    /// </summary>
	    public void Set(CodeableConcept value) => this.region = value;                                                                         // BuildMemberListExtensionValue.cs:474
	                                                                                                                                           // BuildMemberListExtensionValue.cs:424
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:425
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:426
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:428
	                                                                                                                                           // BuildMemberListExtensionValue.cs:429
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:430
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:431
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:433
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:434
	/// <summary>
	/// Class that implements the ClockDirectionExtensionItem' extension slice class.
	/// </summary>
	public class ClockDirectionExtensionItem : ISimpleExtensionItem                                                                            // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice clockDirection
	    /// [Fhir Element 'Extension.extension:clockDirection]'
	    /// </summary>
	    CodeableConcept clockDirection;                                                                                                        // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => this.clockDirection;                                                                                   // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.clockDirection = value;                                                                 // BuildMemberListExtensionValue.cs:474
	                                                                                                                                           // BuildMemberListExtensionValue.cs:424
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:425
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:426
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:428
	                                                                                                                                           // BuildMemberListExtensionValue.cs:429
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:430
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:431
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:433
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:434
	/// <summary>
	/// Class that implements the DepthExtensionItem' extension slice class.
	/// </summary>
	public class DepthExtensionItem : ISimpleExtensionItem                                                                                     // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice depth
	    /// [Fhir Element 'Extension.extension:depth]'
	    /// </summary>
	    CodeableConcept depth;                                                                                                                 // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => this.depth;                                                                                            // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.depth = value;                                                                          // BuildMemberListExtensionValue.cs:474
	                                                                                                                                           // BuildMemberListExtensionValue.cs:424
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:425
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:426
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:428
	                                                                                                                                           // BuildMemberListExtensionValue.cs:429
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:430
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:431
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:433
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:434
	//- LocalClassDefs
}
