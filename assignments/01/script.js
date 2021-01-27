"use strict";

/********************************************************************

STIRRING
Janet Sun

This is a mini stirring game. Player's mission is to pick one "perk potion"
and generate a new "life" using mouse to drag, drop and click.

*********************************************************************/
$(document).ready(setup);

//set up variables
let $cow;
let clickNumber = 0;
let milk = 0;
const moo = new Audio('assets/moo.ogg');
let $info1;
let $info2;
let $info3;
let $info4;
let $info5;
let $info6;

//setup()
//
//set up all variables and make objects draggable when the game starts
function setup() {
  //assign all variables to objects
  $cow = $('#cow');
  $info1 = $('#infoBox1');
  $info2 = $('#infoBox2');
  $info3 = $('#infoBox3');
  $info4 = $('#infoBox4');
  $info5 = $('#infoBox5');
  $info6 = $('#infoBox6');
  $cow.click(pet);
}

//pet()
//
//pet the animal <3
function pet() {
  clickNumber += 1;
  moo.play();
  console.log("ready");
  console.log(clickNumber);
  $('#numberBox').html("X    " + milk);
  $cow.attr(`src`, `assets/cow1.gif`);
  if (clickNumber > 6) {
    $info6.css(`display`, `none`);
    clickNumber = 1;
    milk = milk + 1;
    return;
  }
  if (clickNumber === 1) {
    $info6.css(`display`, `none`);
    $info1.css(`display`, `flex`);
    $info1.css(`position`, `absolute`);
    $info1.css(`top`, `200px`);
  }
  if (clickNumber === 2) {
    $info1.css(`display`, `none`);
    $info2.css(`display`, `flex`);
    $info2.css(`position`, `absolute`);
    $info2.css(`top`, `200px`);
  }
  if (clickNumber === 3) {
    $info2.css(`display`, `none`);
    $info3.css(`display`, `flex`);
    $info3.css(`position`, `absolute`);
    $info3.css(`top`, `200px`);
  }
  if (clickNumber === 4) {
    $info3.css(`display`, `none`);
    $info4.css(`display`, `flex`);
    $info4.css(`position`, `absolute`);
    $info4.css(`top`, `200px`);
  }
  if (clickNumber === 5) {
    $info4.css(`display`, `none`);
    $info5.css(`display`, `flex`);
    $info5.css(`position`, `absolute`);
    $info5.css(`top`, `200px`);
  }
  if (clickNumber === 6) {
    $info5.css(`display`, `none`);
    $info6.css(`display`, `flex`);
    $info6.css(`position`, `absolute`);
    $info6.css(`top`, `200px`);
  }
}
