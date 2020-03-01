using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BodyDistanceFrom' extension class.
	/// </summary>
	public class BodyDistanceFromExtension : MemberListExtension                                                                               // BuildMemberListExtensionValue.cs:317
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:318
	    LandMarkExtensionItem LandMark;                                                                                                        // BuildMemberListExtensionValue.cs:392
	    DistanceFromLandMarkExtensionItem DistanceFromLandMark;                                                                                // BuildMemberListExtensionValue.cs:392
	                                                                                                                                           // BuildMemberListExtensionValue.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension() : base("BodyDistanceFrom")                                                                          // BuildMemberListExtensionValue.cs:324
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:325
	        this.LandMark = new LandMarkExtensionItem();                                                                                       // BuildMemberListExtensionValue.cs:395
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtensionItem();                                                               // BuildMemberListExtensionValue.cs:395
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:327
	                                                                                                                                           // BuildMemberListExtensionValue.cs:328
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:329
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.LandMark);                                                                                                          // BuildMemberListExtensionValue.cs:398
	        this.Read(this.DistanceFromLandMark);                                                                                              // BuildMemberListExtensionValue.cs:398
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:335
	                                                                                                                                           // BuildMemberListExtensionValue.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:340
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:341
	        this.Write(this.LandMark);                                                                                                         // BuildMemberListExtensionValue.cs:401
	        this.Write(this.DistanceFromLandMark);                                                                                             // BuildMemberListExtensionValue.cs:401
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:343
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:344
	/// <summary>
	/// Class that implements the LandMarkExtensionItem' extension slice class.
	/// </summary>
	public class LandMarkExtensionItem : ISimpleExtensionItem                                                                                  // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice landMark
	    /// [Fhir Element 'Extension.extension:landMark]'
	    /// </summary>
	    CodeableConcept landMark;                                                                                                              // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => this.landMark;                                                                                         // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.landMark = value;                                                                       // BuildMemberListExtensionValue.cs:474
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
	/// Class that implements the DistanceFromLandMarkExtensionItem' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtensionItem : ISimpleExtensionItem                                                                      // BuildMemberListExtensionValue.cs:421
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:422
	    /// <summary>
	    /// Field for extension slice distanceFromLandMark
	    /// [Fhir Element 'Extension.extension:distanceFromLandMark]'
	    /// </summary>
	    Quantity distanceFromLandMark;                                                                                                         // BuildMemberListExtensionValue.cs:460
	                                                                                                                                           // BuildMemberListExtensionValue.cs:461
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => this.distanceFromLandMark;                                                                                    // BuildMemberListExtensionValue.cs:465
	                                                                                                                                           // BuildMemberListExtensionValue.cs:470
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.distanceFromLandMark = value;                                                                  // BuildMemberListExtensionValue.cs:474
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
