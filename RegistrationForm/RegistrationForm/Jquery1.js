$(document).ready(function () {
    $('#Button1').click(
        function () {



            var name = $('#Name').val();
            //var LastName = $('#LNameTextBox').val();
            var Email = $('#Email').val();
            var ContactNumber = $('#Contact').val();
            if (!name) {
                alert("Name");
                return false;
            }
            else if (!name.match('^[a-zA-Z]*$')) {
                alert("First incorrect");
                return false;
            }
          
            else if (!Email) {
                alert("Email");
                return false;
            }
            else if (!Email.match('^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$')) {
                alert("Email incorrect");
                return false;
            }
            else if (!ContactNumber) {
                alert("Contact Number");
                return false;
            }
            else if (!ContactNumber.match('^[0-9]{10}$')) {
                alert("Contact Number incorrect");
                return false;
            }
            else {
                return true;
            }
        }
    );
});