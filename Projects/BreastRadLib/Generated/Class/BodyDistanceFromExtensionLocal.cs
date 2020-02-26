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
	public class BodyDistanceFromExtension : MemberListExtensionValueBase                                                                      // BuildMemberListExtensionValue.cs:307
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:308
	    LandMarkExtensionItem LandMark;                                                                                                        // BuildMemberListExtensionValue.cs:383
	    DistanceFromLandMarkExtensionItem DistanceFromLandMark;                                                                                // BuildMemberListExtensionValue.cs:383
	                                                                                                                                           // BuildMemberListExtensionValue.cs:310
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension() : base("BodyDistanceFrom")                                                                          // BuildMemberListExtensionValue.cs:314
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:315
	        this.LandMark = new LandMarkExtensionItem();                                                                                       // BuildMemberListExtensionValue.cs:386
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtensionItem();                                                               // BuildMemberListExtensionValue.cs:386
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:317
	                                                                                                                                           // BuildMemberListExtensionValue.cs:318
	    public void Read()                                                                                                                     // BuildMemberListExtensionValue.cs:319
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:320
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.LandMark);                                                                                                          // BuildMemberListExtensionValue.cs:389
	        this.Read(this.DistanceFromLandMark);                                                                                              // BuildMemberListExtensionValue.cs:389
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:325
	                                                                                                                                           // BuildMemberListExtensionValue.cs:326
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtensionValue.cs:330
	    {                                                                                                                                      // BuildMemberListExtensionValue.cs:331
	        this.Write(this.LandMark);                                                                                                         // BuildMemberListExtensionValue.cs:392
	        this.Write(this.DistanceFromLandMark);                                                                                             // BuildMemberListExtensionValue.cs:392
	    }                                                                                                                                      // BuildMemberListExtensionValue.cs:333
	}                                                                                                                                          // BuildMemberListExtensionValue.cs:334
	/// <summary>
	/// Class that implements the LandMarkExtensionItem' extension slice class.
	/// </summary>
	public class LandMarkExtensionItem : ISimpleExtensionItem                                                                                  // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice landMark
	    /// [Fhir Element 'Extension.extension:landMark]'
	    /// </summary>
	    CodeableConcept landMark;                                                                                                              // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => this.landMark;                                                                                         // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.landMark = value;                                                                       // BuildMemberListExtensionValue.cs:461
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
	/// Class that implements the DistanceFromLandMarkExtensionItem' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtensionItem : ISimpleExtensionItem                                                                      // BuildMemberListExtensionValue.cs:408
	{                                                                                                                                          // BuildMemberListExtensionValue.cs:409
	    /// <summary>
	    /// Field for extension slice distanceFromLandMark
	    /// [Fhir Element 'Extension.extension:distanceFromLandMark]'
	    /// </summary>
	    Quantity distanceFromLandMark;                                                                                                         // BuildMemberListExtensionValue.cs:447
	                                                                                                                                           // BuildMemberListExtensionValue.cs:448
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => this.distanceFromLandMark;                                                                                    // BuildMemberListExtensionValue.cs:452
	                                                                                                                                           // BuildMemberListExtensionValue.cs:457
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.distanceFromLandMark = value;                                                                  // BuildMemberListExtensionValue.cs:461
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
