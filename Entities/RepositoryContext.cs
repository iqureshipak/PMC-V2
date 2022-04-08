using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<Notificationtatus> Notificationtatus { get; set; }
        public virtual DbSet<ExamSession> ExamSession { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamCenter> ExamCenter { get; set; }
        public virtual DbSet<GraduatingType> GraduatingType { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<LicensingPathway> LicensingPathway { get; set; }
        public virtual DbSet<LicenseLicensingPathway> LicenseLicensingPathway { get; set; }
        public virtual DbSet<LicenseCheck> LicenseCheck { get; set; }
        public virtual DbSet<LicensingPathwayLicenseCheck> LicensingPathwayLicenseCheck { get; set; }
        public virtual DbSet<PMCUserLicense> PMCUserLicense { get; set; }
        public virtual DbSet<PMCUserLicenseSupportingDocument> PMCUserLicenseSupportingDocument { get; set; }
        public virtual DbSet<AdmissionRequest> AdmissionRequest { get; set; }
        public virtual DbSet<CareerApplyOnline> CareerApplyOnline { get; set; }
        public virtual DbSet<AccreditationAndInspection> AccreditationAndInspection { get; set; }
        public virtual DbSet<AdmissionRegulation> AdmissionRegulation { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationDetail> ApplicationDetail { get; set; }
        public virtual DbSet<ApplicationHandler> ApplicationHandler { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<ApplicationWorkflow> ApplicationWorkflow { get; set; }
        public virtual DbSet<BankTransaction> BankTransaction { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<Certification> Certification { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<CollegeSession> CollegeSession { get; set; }
        public virtual DbSet<CollegeTransfer> CollegeTransfer { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<CommunicationDetail> CommunicationDetail { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DCComplaint> DCComplaint { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Desk> Desk { get; set; }
        public virtual DbSet<Dispatch> Dispatch { get; set; }
        public virtual DbSet<DispatchSubject> DispatchSubject { get; set; }
        public virtual DbSet<DispatchThrough> DispatchThrough { get; set; }
        public virtual DbSet<DispatchType> DispatchType { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<UserLicense> DoctorLicense { get; set; }
        public virtual DbSet<Duration> Duration { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Faculties> Faculties { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<FacultyCollege> FacultyCollege { get; set; }
        public virtual DbSet<FacultyDesignation> FacultyDesignation { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<GalleryAndMediaClipping> GalleryAndMediaClipping { get; set; }
        public virtual DbSet<GeneralPage> GeneralPage { get; set; }
        public virtual DbSet<GroupPayment> GroupPayment { get; set; }
        public virtual DbSet<InternalUser> InternalUser { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<LawAndJournal> LawAndJournal { get; set; }
        public virtual DbSet<MDCATResult> MDCATResult { get; set; }
        public virtual DbSet<MDCATSession> MDCATSession { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<NADRARecord> NADRARecord { get; set; }
        public virtual DbSet<NLESession> NLESession { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<PageType> PageType { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentAccount> PaymentAccount { get; set; }
        public virtual DbSet<PaymentCurrency> PaymentCurrency { get; set; }
        public virtual DbSet<PMCAuthorityBoardAndCouncil> PMCAuthorityBoardAndCouncil { get; set; }
        public virtual DbSet<PMCOfficialDocument> PMCOfficialDocument { get; set; }
        public virtual DbSet<PMCTests> PMCTests { get; set; }
        public virtual DbSet<PMCUser> PMCUser { get; set; }
        public virtual DbSet<PMCUserGoodStandingCertificate> PMCUserCertificate { get; set; }
        public virtual DbSet<PMCUserEducation> PMCUserEducation { get; set; }
        public virtual DbSet<PMCUserExam> PMCUserExamResult { get; set; }
        public virtual DbSet<PMCUserInvoice> PMCUserInvoice { get; set; }
        public virtual DbSet<PMCUserSpecialization> PMCUserSpecialization { get; set; }
        public virtual DbSet<PoliciesAndDecision> PoliciesAndDecision { get; set; }
        public virtual DbSet<PressRelease> PressRelease { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<PublicNotice> PublicNotice { get; set; }
        public virtual DbSet<PublicUser> PublicUser { get; set; }
        public virtual DbSet<RegulationForm> RegulationForm { get; set; }
        public virtual DbSet<RegulationRule> RegulationRule { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<SpecializationLevel> SpecializationLevel { get; set; }
        public virtual DbSet<SpecializationType> SpecializationType { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<TeachingHospital> TeachingHospital { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<VerificationEmail> VerificationEmail { get; set; }
        public virtual DbSet<VerificationType> VerificationType { get; set; }
        public virtual DbSet<PMCUserPayment> PMCUserPayment { get; set; }
        public virtual DbSet<CommunicationDetailSupportingDocument> CommunicationDetailSupportingDocument { get; set; }
        public virtual DbSet<ApplicationSupportingDocument> ApplicationSupportingDocument { get; set; }
        public virtual DbSet<NLEStudent> NLEStudent { get; set; }
        public virtual DbSet<TempUserCriticalInformation> TempUserCriticalInformation { get; set; }
        public virtual DbSet<MeritList> MeritList { get; set; }
        public virtual DbSet<TempMDCATResult> TempMDCATResult { get; set; }
        public virtual DbSet<TempForwardMDCATCollegeResult> TempForwardMDCATCollegeResult { get; set; }
        public virtual DbSet<CollegeGraduateStudents> CollegeGraduateStudents { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<LocalQualification> LocalQualification { get; set; }
        public virtual DbSet<NEBStudent> NEBStudent { get; set; }
        public virtual DbSet<NEBResultTemp> NEBResultTemp { get; set; }
        public virtual DbSet<NLEResultTemp> NLEResultTemp { get; set; }
        public virtual DbSet<TempPMCUserStudentUpdate> TempPMCUserStudentUpdate { get; set; }
        public virtual DbSet<DoctorWorkDetail> DoctorWorkDetail { get; set; }
        public virtual DbSet<PmcUserDegree> DoctorDegree { get; set; }
        public virtual DbSet<TempProvisionalLicense> TempProvisionalLicense { get; set; }
        public virtual DbSet<Degree> Degree { get; set; }
        public virtual DbSet<CME> CME { get; set; }
        public virtual DbSet<CPD> CPD { get; set; }
        public virtual DbSet<PMCUserDuplicateLicense> PMCUserDuplicateLicense { get; set; }
        public virtual DbSet<PMCUserProvisionalLicenseExtension> PMCUserProvisionalLicenseExtension { get; set; }
        public virtual DbSet<PMCUserAttestationRequest> PMCUserAttestationRequest { get; set; }
        public virtual DbSet<ApplicationServiceFee> ApplicationServiceFee { get; set; }
        public virtual DbSet<PMCUserDegreeSupportingDocument> PMCUserDegreeSupportingDocument { get; set; }
        public virtual DbSet<PMCUserCTFormVerification> PMCUserCTFormVerification { get; set; }
        public virtual DbSet<PMCUserVerificationofPracticalExperience> PMCUserVerificationofPracticalExperience { get; set; }
        public virtual DbSet<PMCUserPracticalExperienceSupportingDocument> PMCUserPracticalExperienceSupportingDocument { get; set; }
        public virtual DbSet<Hospital> Hospital { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
