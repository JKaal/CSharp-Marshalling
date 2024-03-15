cmake_minimum_required (VERSION 3.8)

include_directories(include)
include_directories(../sub-project/include)

set(EXECUTABLE_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/bin)
make_directory(${EXECUTABLE_OUTPUT_PATH})

add_executable (master-project
                "source/main.cpp")
target_compile_features(master-project PUBLIC cxx_std_17)
target_link_libraries(master-project 
                      sub-project)