let mytooltipbutton = $(document).find('#mytooltip');
mytooltipbutton.tooltip({
  placement: 'auto',
  boundary: 'window',
  html: true,
  sanitize: false,
  trigger: 'click',
  title: '<iframe width="640" height="360" src="https://www.youtube.com/embed/jDjTBn7orFg"</iframe>'
})

const mytooltip = document.getElementById('mytooltip');
mytooltip.addEventListener('click', function handleClick() {
  const initialText = 'Close Tooltip';

  if (mytooltip.textContent.toLowerCase().includes(initialText.toLowerCase())) {
    mytooltip.innerHTML =
      '<span>Video Tooltip Button</span>';
  } else {
    mytooltip.textContent = initialText;
  }
});