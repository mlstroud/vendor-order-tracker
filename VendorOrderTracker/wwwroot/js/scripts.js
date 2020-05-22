$(document).ready(function () {
  let pathName = window.location.pathname;

  if (pathName.includes("vendors")) {
    $(".panel").slideDown();
  } else {
    $("#splash").fadeIn(1500);
  }
});