using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;
//+Usings
//-Usings

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BodyDistanceFrom' extension class.
	/// </summary>
	public class BodyDistanceFromExtension : MemberListExtensionComplex                                                                        // BuildMemberListExtension.cs:319
	{                                                                                                                                          // BuildMemberListExtension.cs:320
	    LandMarkExtension LandMark;                                                                                                            // BuildMemberListExtension.cs:459
	    DistanceFromLandMarkExtension DistanceFromLandMark;                                                                                    // BuildMemberListExtension.cs:459
	                                                                                                                                           // BuildMemberListExtension.cs:322
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension(BreastRadiologyDocument doc) : base("BodyDistanceFrom")                                               // BuildMemberListExtension.cs:326
	    {                                                                                                                                      // BuildMemberListExtension.cs:327
	        this.Init(doc, 0, 2147483647);                                                                                                     // BuildMemberListExtension.cs:328
	        this.LandMark = new LandMarkExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:462
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtension(this.doc);                                                           // BuildMemberListExtension.cs:462
	    }                                                                                                                                      // BuildMemberListExtension.cs:330
	                                                                                                                                           // BuildMemberListExtension.cs:331
	    /// <summary>
	    /// Read extension values
	    /// </summary>
	    public override void ReadItems(IEnumerable<Extension> e)                                                                               // BuildMemberListExtension.cs:335
	    {                                                                                                                                      // BuildMemberListExtension.cs:336
	        this.LandMark.ReadItems(e);                                                                                                        // BuildMemberListExtension.cs:465
	        this.DistanceFromLandMark.ReadItems(e);                                                                                            // BuildMemberListExtension.cs:465
	    }                                                                                                                                      // BuildMemberListExtension.cs:338
	                                                                                                                                           // BuildMemberListExtension.cs:339
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public override IEnumerable<Extension> WriteItems()                                                                                    // BuildMemberListExtension.cs:343
	    {                                                                                                                                      // BuildMemberListExtension.cs:344
	        List<Extension> retVal = new List<Extension>();                                                                                    // BuildMemberListExtension.cs:345
	        retVal.AddRange(this.LandMark.WriteItems());                                                                                       // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.DistanceFromLandMark.WriteItems());                                                                           // BuildMemberListExtension.cs:468
	        return retVal.ToArray();                                                                                                           // BuildMemberListExtension.cs:347
	    }                                                                                                                                      // BuildMemberListExtension.cs:348
	}                                                                                                                                          // BuildMemberListExtension.cs:349
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the LandMarkExtension' extension slice class.
	/// </summary>
	public class LandMarkExtension : MemberListExtensionSimple<CodeableConcept>                                                                // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:533
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:537
	                                                                                                                                           // BuildMemberListExtension.cs:542
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:546
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public LandMarkExtension(BreastRadiologyDocument doc) : base("LandMarkExtension")                                                      // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the DistanceFromLandMarkExtension' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtension : MemberListExtensionSimple<Quantity>                                                           // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:533
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => (Quantity) this.First();                                                                                      // BuildMemberListExtension.cs:537
	                                                                                                                                           // BuildMemberListExtension.cs:542
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.SetSingleItem(value);                                                                          // BuildMemberListExtension.cs:546
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DistanceFromLandMarkExtension(BreastRadiologyDocument doc) : base("DistanceFromLandMarkExtension")                              // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	//- LocalClassDefs
}
