var isValid = function(s) {
  const openStack = [];
  for (let i = 0; i < s.length; i++) {
    const paren = s[i];
    if (paren === '(' || paren === '[' || paren === '{') {
      openStack.push(paren);
    } else {
      if (
        (paren === ')' && openStack[openStack.length - 1] === '(') ||
        (paren === ']' && openStack[openStack.length - 1] === '[') ||
        (paren === '}' && openStack[openStack.length - 1] === '{')
      ) {
        openStack.pop();
      } else {
        return false;
      }
    }
  }
  return openStack.length === 0;
}
