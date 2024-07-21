using System.ComponentModel.DataAnnotations;

namespace ConferenceAttendees.Api.Data
{
    public class Attendee : BaseEntity
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [MaxLength(50)]
        public required string LastName { get; set; } = string.Empty;
        [MaxLength(150)]
        public required string EmailAddress { get; set; } = string.Empty;
        [MaxLength(14)]
        public required string PhoneNumber { get; set; } = string.Empty;
        [MaxLength(150)]
        public required string CompanyName { get; set; } = string.Empty;

        public ReferralSource? ReferralSource { get; set; }
        public Guid ReferralSourceId { get; set; }

        public JobRole? JobRole { get; set; }
        public Guid JobRoleId { get; set; }


        public Gender? Gender { get; set; }
        public Guid GenderId { get; set; }

    }
}
