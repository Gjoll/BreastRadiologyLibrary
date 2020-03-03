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
	public class BodyDistanceFromExtension : MemberListExtensionComplex                                                                        // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    LandMarkExtension LandMark;                                                                                                            // BuildMemberListExtension.cs:394
	    DistanceFromLandMarkExtension DistanceFromLandMark;                                                                                    // BuildMemberListExtension.cs:394
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension() : base("BodyDistanceFrom")                                                                          // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.LandMark = new LandMarkExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:397
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtension(this.doc);                                                           // BuildMemberListExtension.cs:397
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    /// <summary>
	    /// Read extension values
	    /// </summary>
	    protected override void ReadItems(IEnumerable<Extension> e)                                                                            // BuildMemberListExtension.cs:332
	    {                                                                                                                                      // BuildMemberListExtension.cs:333
	        this.LandMark.ReadItems(e);                                                                                                        // BuildMemberListExtension.cs:400
	        this.DistanceFromLandMark.ReadItems(e);                                                                                            // BuildMemberListExtension.cs:400
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    protected override IEnumerable<Extension> WriteItems()                                                                                 // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        List<Extension> retVal = new List<Extension>();                                                                                    // BuildMemberListExtension.cs:342
	        retVal.AddRange(this.LandMark.WriteItems());                                                                                       // BuildMemberListExtension.cs:403
	        retVal.AddRange(this.DistanceFromLandMark.WriteItems());                                                                           // BuildMemberListExtension.cs:403
	        return retVal.ToArray();                                                                                                           // BuildMemberListExtension.cs:344
	    }                                                                                                                                      // BuildMemberListExtension.cs:345
	}                                                                                                                                          // BuildMemberListExtension.cs:346
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the LandMarkExtension' extension slice class.
	/// </summary>
	public class LandMarkExtension : MemberListExtensionSimple<CodeableConcept>                                                                // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	                                                                                                                                           // BuildMemberListExtension.cs:468
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:472
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public LandMarkExtension(BreastRadiologyDocument doc) : base("LandMarkExtension")                                                      // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the DistanceFromLandMarkExtension' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtension : MemberListExtensionSimple<Quantity>                                                           // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	                                                                                                                                           // BuildMemberListExtension.cs:468
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => (Quantity) this.First();                                                                                      // BuildMemberListExtension.cs:472
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.SetSingleItem(value);                                                                          // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DistanceFromLandMarkExtension(BreastRadiologyDocument doc) : base("DistanceFromLandMarkExtension")                              // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	//- LocalClassDefs
}
