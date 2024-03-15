cmake_minimum_required (VERSION 3.8)

include(GenerateExportHeader)
file(GLOB cppFiles "source/*.cpp" ${CMAKE_CURRENT_BINARY_DIR}/sub-project_exports.h)

include_directories(include)

set(LIBRARY_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/bin)
make_directory(${LIBRARY_OUTPUT_PATH})

add_library(sub-project SHARED ${cppFiles})
GENERATE_EXPORT_HEADER(sub-project           
                       BASE_NAME sub-project
                       EXPORT_MACRO_NAME SUB_PROJECT_EXPORTS
                       EXPORT_FILE_NAME ${CMAKE_CURRENT_BINARY_DIR}/sub-project_exports.h
                       STATIC_DEFINE SHARED_EXPORTS_BUILT_AS_STATIC)
target_include_directories(sub-project
                           PUBLIC ${CMAKE_CURRENT_BINARY_DIR})
target_compile_features(sub-project PUBLIC cxx_std_17)
