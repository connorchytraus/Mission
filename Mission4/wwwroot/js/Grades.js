const { write } = require("@popperjs/core");

$("#buttonCalc").click(function () {
    // calculate final grade from index.html form
    let total = ($("#assignment").val() * 0.5) + ($("#group").val() * 0.1) + ($("#quiz").val() * 0.1) + ($("#mid").val() * 0.1)
        + ($("#final").val() * 0.1) + ($("#intex").val() * 0.1);

    let grade = "tbd";

    //determines final letter grade
    if (total >= 94) {
        grade = "A"
    }
    else if (total >= 90) {
        grade = "A-"
    }
    else if (total >= 87) {
        grade = "B+"
    }
    else if (total >= 84) {
        grade = "B"
    }
    else if (total >= 80) {
        grade = "B-"
    }
    else if (total >= 77) {
        grade = "C+"
    }
    else if (total >= 74) {
        grade = "C"
    }
    else if (total >= 70) {
        grade = "C-"
    }
    else if (total >= 67) {
        grade = "D+"
    }
    else if (total >= 64) {
        grade = "D"
    }
    else if (total >= 60) {
        grade = "D-"
    }
    else {
        grade = "E"
    }

    //returns final grade to ouput of the form
    window.print(grade);
})