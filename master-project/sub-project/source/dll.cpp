#include "dll.hpp"

int foo::bar(const char *msg)
{
  std::cout << "msg string:" << msg << " and msg len:" << strlen(msg) << std::endl;
  return strlen(msg);
}
