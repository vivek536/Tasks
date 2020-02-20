function validate() {
    //console.log(name);
    var name = document.getElementById("Name").value;
    var email = document.getElementById("Email").value;
    var contact = document.getElementById("Contact").value;
    var country = document.getElementById("DropDownList1").value;
    var state = document.getElementById("DropDownList2").value;
    var city = document.getElementById("DropDownList3").value;
    var dob = document.getElementById("Calendar1").value; 
    if (name == '' ) {
        document.getElementById("Mandate_Name").innerHTML = "Name required"
        document.getElementById("Mandate_Name").style.color = "red"
        return false;
    }
    else if (!Email) {
        alert("Email is not entered");
        return false;
    }
    else if (!(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email))) {
        alert("Email is invalid");
        return false;
    }
    else if (!contact) {
        alert("Contact Number is not entered");
        return false;
    }
  
    else if(!country) {
        alert("Please select the Country");
        return false;
    }
    return true;
}