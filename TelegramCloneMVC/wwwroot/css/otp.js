﻿//const inputs = document.querySelectorAll("input"),
//    button = document.querySelector("button");

//// iterate over all inputs
//inputs.forEach((input, index1) => {
//    input.addEventListener("input", (e) => {  // Remove 'async' from this line

//        const currentInput = input,
//            nextInput = input.nextElementSibling,
//            prevInput = input.previousElementSibling;

//        if (currentInput.value.length > 1) {
//            currentInput.value = "";
//            return;
//        }

//        if (nextInput && nextInput.hasAttribute("disabled") && currentInput.value !== "") {
//            nextInput.removeAttribute("disabled");
//            nextInput.focus();
//        }

//        if (e.inputType === "deleteContentBackward") {
//            inputs.forEach((input, index2) => {

//                if (index1 <= index2 && prevInput) {
//                    input.setAttribute("disabled", true);
//                    input.value = "";
//                    prevInput.focus();
//                }
//            });
//        }

//        if (!inputs[3].disabled && inputs[3].value !== "") {
//            button.classList.add("active");
//        } else {
//            button.classList.remove("active");
//        }
//    });
//});

//window.addEventListener("load", () => inputs[0].focus());
