/* Ticket.cs		Author:	Doyle	
 * Describes the characteristics of a
 * speeding ticket to include the speed
 * limit, ticketed speed and fine amount.
 * The Ticket class is used to set the
 * amount for the fine. 
 * **************************************/

using System;

namespace TicketApp
{
    class Ticket
    {
        private const
            decimal COST_PER_5_OVER = 87.50M;
        private string studentNumber;
        private char classif;
        private int speedLimit;
        private int speedTraveling;

        public Ticket()
        {

        }

        public Ticket(string sNum, char yrInSchool,
                        int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed;
            classif = yrInSchool;
        }

        public Ticket(string sNum, int speedLmt, int reportedSpeed)
        {
            studentNumber = sNum;
            speedLimit = speedLmt;
            speedTraveling = reportedSpeed - speedLimit;
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public char Classif
        {
            get
            {
                return classif;
            }
            set
            {
                classif = value;
            }
        }

        public int SpeedLimt
        {
            get
            {
                return speedLimit;
            }
            set
            {
                speedLimit = value;
            }
        }

        public int Speed
        {
            get
            {
                return speedTraveling;
            }
            set
            {
                speedTraveling = value;
            }
        }


        public decimal SetFine()
        {
            int milesOverSpeedLimit = speedTraveling - speedLimit;
            decimal fine;

            fine = (milesOverSpeedLimit / 5 * COST_PER_5_OVER) + 75.00M;
            if (classif == '4')
                if (milesOverSpeedLimit > 20)
                    fine += 200;
                else
                    fine += 50;
            else
                if (classif == '1')
                if (milesOverSpeedLimit < 20)
                    fine -= 50;
                else
                    fine += 100;
            else
                    if (milesOverSpeedLimit > 19)
                fine += 100;
            return fine;
        }

        public string ReturnNameOfClassification()
        {
            string classificationName;
            switch (classif)
            {
                case '1':
                    classificationName = "Freshman";
                    break;
                case '2':
                    classificationName = "Sophomore";
                    break;
                case '3':
                    classificationName = "Junior";
                    break;
                case '4':
                    classificationName = "Senior";
                    break;
                default:
                    classificationName = "Unspecified";
                    break;
            }
            return classificationName;
        }

        public override string ToString()
        {
            return "\tTicket App" +
                "\n\nStudent number:  " + studentNumber +
                "\nClassification:  " + ReturnNameOfClassification() +
                "\nSpeed limit:  " + speedLimit +
                "\nReported speed:  " + speedTraveling +
                "\n\nFine:  " + SetFine().ToString("C");
        }
    }
}
